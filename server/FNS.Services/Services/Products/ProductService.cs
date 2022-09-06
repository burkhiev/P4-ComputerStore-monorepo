using AutoMapper;
using FNS.Domain.Exceptions;
using FNS.Domain.Models;
using FNS.Domain.Models.Products;
using FNS.Domain.Repositories;
using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Abstractions.Products;
using FNS.Services.Dtos;
using FNS.Services.Dtos.Products;
using FNS.Services.Mappers.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace FNS.Services.Services.Products
{
    internal sealed class ProductService : IProductsService
    {
        private readonly IRootRepository _rootRepository;
        private readonly ProductMapperConfiguration _productMapperConfig;
        private readonly ProductAttributesMapperConfiguration _productAttributeMapperConfig;
        private readonly SubCategoryMapperConfiguration _subCategoryMapperConfig;

        public ProductService(IRootRepository rootRepository)
        {
            _rootRepository = rootRepository;
            _productMapperConfig = new ProductMapperConfiguration();
            _productAttributeMapperConfig = new ProductAttributesMapperConfiguration();
            _subCategoryMapperConfig = new SubCategoryMapperConfiguration();
        }

        private IRootRepository RootRepository => _rootRepository;
        private IMapper ProductMapper => _productMapperConfig.Mapper;
        private IMapper ProductAttributeMapper => _productAttributeMapperConfig.Mapper;
        private IMapper SubCategoryMapper => _subCategoryMapperConfig.Mapper;

        public AppOpResult<IEnumerable<ProductDto>> GetAllProducts()
        {
            var products = RootRepository.Products.GetAll().ToArray();
            var productsDtos = ProductMapper.Map<IEnumerable<ProductDto>>(products);

            var result = new AppOpResult<IEnumerable<ProductDto>>(productsDtos);
            return result;
        }

        public AppOpResult<IEnumerable<ProductDto>> GetProductsBySubCategoryId(string subCategoryId)
        {
            var products = RootRepository.Products
                .FindByCondition(product => product.SubCategoryId == subCategoryId);
            var productsDtos = ProductMapper.Map<IEnumerable<ProductDto>>(products);

            var result = new AppOpResult<IEnumerable<ProductDto>>(productsDtos);
            return result;
        }

        public async Task<AppOpResult<ProductWithAdditionalInfoDto>> GetProductWithAdditionalInfoByIdAsync(string id, CancellationToken ct = default)
        {
            var product = await RootRepository.Products.FindByIdAsync(id, ct);

            if(product is null)
            {
                var errResult = new EntityNotFoundOpResult<ProductWithAdditionalInfoDto>();
                return errResult;
            }

            await RootRepository.Products.LoadAttributesAndTheirValuesAsync(product, ct);

            var dto = ProductMapper.Map<Product, ProductWithAdditionalInfoDto>(product);
            var result = new AppOpResult<ProductWithAdditionalInfoDto>(dto);

            return result;
        }

        public async Task<AppOpResult<ProductWithAdditionalInfoDto>> CreateProduct(ProductForCreateDto dto)
        {
            var product = ProductMapper.Map<Product>(dto);

            product.Id = Guid.NewGuid().ToString();
            await RootRepository.Products.AddAsync(product);


            var subCategory = await RootRepository.SubCategories.FindByIdAsync(product.SubCategoryId);

            if(subCategory is null)
            {
                var fault = new ProductNotCreatedDueInvalidSubCategoryIdOpResult();
                return fault;
            }


            bool someAttributeNotFound = false;

            foreach(var attrValue in dto.AdditionalAttributes)
            {
                var attr = await RootRepository.ProductAttributes.FindByIdAsync(attrValue.Key);

                if(attr is null)
                {
                    someAttributeNotFound = true;
                    break;
                }

                var newAttrValue = new ProductAttributeValue
                {
                    Id = Guid.NewGuid().ToString(),
                    ProductId = product.Id,
                    ProductAttributeId = attrValue.Key,
                    Value = attrValue.Value?.ToString()
                };

                await RootRepository.ProductWithAttributeValues.AddAsync(newAttrValue);
            }

            if(someAttributeNotFound)
            {
                var fault = new ProductNotCreatedDueInvalidAttributeIdOpResult();
                return fault;
            }


            await RootRepository.SaveChangesAsync();

            var newDto = ProductMapper.Map<ProductWithAdditionalInfoDto>(product);
            var result = new AppOpResult<ProductWithAdditionalInfoDto>(newDto);

            return result;
        }

        public async Task<AppOpResult<ProductWithAdditionalInfoDto>> UpdateProduct(ProductWithAdditionalInfoDto dto)
        {
            // Проверка на конкурентность
            // При установке Xmin Concurrency Token на уже загруженную сущность
            // автоматический отлов конфликтов при сохранении не работает.
            var product = ProductMapper.Map<Product>(dto);
            RootRepository.Products.Update(product);


            // удаление отсутствующих значений доп. атрибутов
            var attrIds = dto.AdditionalAttributes.Keys.Cast<string>();
            var allAttrs = RootRepository.ProductAttributes.GetAll().ToList();

            var curAttrValues = RootRepository.ProductWithAttributeValues
                .FindByCondition(x => x.ProductId == product.Id)
                .ToList();

            // сравнение: что было, что стало
            var attrsForDelete = curAttrValues.ExceptBy(attrIds, x => x.Id);

            foreach(var attr in attrsForDelete)
            {
                RootRepository.ProductWithAttributeValues.Remove(attr);
            }


            // изменение/добавление полученных значений доп. атрибутов
            bool someAttrIsNotFound = false;

            foreach(var receivedAttr in dto.AdditionalAttributes)
            {
                var attrsValues = curAttrValues.Where(x => x.ProductAttributeId == receivedAttr.Key).ToList();

                if(attrsValues.Count() == 0)
                {
                    var attrValue = new ProductAttributeValue
                    {
                        Id = Guid.NewGuid().ToString(),
                        ProductId = product.Id,
                        ProductAttributeId = receivedAttr.Key,
                        Value = receivedAttr.Value?.ToString(),
                    };

                    await RootRepository.ProductWithAttributeValues.AddAsync(attrValue);
                }
                else if(attrsValues.Count() == 1)
                {
                    var attrValue = attrsValues[0];
                    attrValue.Value = receivedAttr.Value?.ToString();
                    RootRepository.ProductWithAttributeValues.Update(attrValue);
                }
                else
                {
                    throw new UnknownException();
                }
            }

            if(someAttrIsNotFound)
            {
                var fault = new ProductNotUpdatedDueInvalidAttributeIdOpResult();
                return fault;
            }


            // Фиксация изменений
            try
            {
                await RootRepository.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException ex)
            {
                var fault = new InvalidDbConcurrencyUpdateOpResult<ProductWithAdditionalInfoDto>();
                return fault;
            }
            catch(DbUpdateException ex)
            {
                var fault = new InvalidDbUpdateOpResult<ProductWithAdditionalInfoDto>();
                return fault;
            }


            var newProduct = await RootRepository.Products.FindByIdAsync(product.Id);
            var productDto = ProductMapper.Map<ProductWithAdditionalInfoDto>(product);
            var result = new AppOpResult<ProductWithAdditionalInfoDto>(productDto);

            return result;
        }

        public async Task<AppOpResult<EmptyDto>> DeleteProductAsync(string id)
        {
            var product = await RootRepository.Products.FindByIdAsync(id);

            if(product is not null)
            {
                RootRepository.Products.Remove(product);
                await RootRepository.SaveChangesAsync();
            }

            var result = new AppOpResult<EmptyDto>();
            return result;
        }

        public AppOpResult<IEnumerable<ProductAttributeDto>> GetAllProductAttributes()
        {
            var attributes = RootRepository.ProductAttributes.GetAll().ToList();
            var dtos = ProductAttributeMapper.Map<IEnumerable<ProductAttributeDto>>(attributes);

            var result = new AppOpResult<IEnumerable<ProductAttributeDto>>(dtos);
            return result;
        }

        public async Task<AppOpResult<ProductAttributeDto>> CreateProductAttributeAsync(ProductAttributeForCreateDto attrDto)
        {
            var attr = ProductAttributeMapper.Map<ProductAttribute>(attrDto);
            attr.Id = Guid.NewGuid().ToString();

            var newAttr = await RootRepository.ProductAttributes.AddAsync(attr);
            await RootRepository.SaveChangesAsync();

            var dto = ProductAttributeMapper.Map<ProductAttributeDto>(newAttr);
            var result = new AppOpResult<ProductAttributeDto>(dto);

            return result;
        }

        public async Task<AppOpResult<ProductAttributeDto>> UpdateProductAttribute(ProductAttributeDto attrDto)
        {
            var attribute = ProductAttributeMapper.Map<ProductAttribute>(attrDto);
            RootRepository.ProductAttributes.Update(attribute);


            try
            {
                await RootRepository.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException ex)
            {
                var fault = new InvalidDbConcurrencyUpdateOpResult<ProductAttributeDto>();
                return fault;
            }
            catch(DbUpdateException ex)
            {
                var fault = new InvalidDbUpdateOpResult<ProductAttributeDto>();
                return fault;
            }


            var newAttrDto = ProductAttributeMapper.Map<ProductAttributeDto>(attribute);
            var result = new AppOpResult<ProductAttributeDto>(newAttrDto);

            return result;
        }

        public async Task<AppOpResult<EmptyDto>> DeleteProductAttributeAsync(string id)
        {
            var attribute = await RootRepository.ProductAttributes.FindByIdAsync(id);

            if(attribute is not null)
            {
                RootRepository.ProductAttributes.Remove(attribute);
                await RootRepository.SaveChangesAsync();
            }

            var result = new AppOpResult<EmptyDto>();
            return result;
        }

        public AppOpResult<IEnumerable<SubCategoryDto>> GetAllSubCategories()
        {
            var subCategories = RootRepository.SubCategories.GetAll().ToList();
            var dtos = SubCategoryMapper.Map<IEnumerable<SubCategoryDto>>(subCategories);

            var result = new AppOpResult<IEnumerable<SubCategoryDto>>(dtos);
            return result;
        }

        public async Task<AppOpResult<SubCategoryDto>> CreateSubCategoryAsync(SubCategoryForCreateDto attrDto)
        {
            var subCategory = new SubCategory 
            { 
                Id = Guid.NewGuid().ToString(),
                Name = attrDto.Name ,
            };

            await RootRepository.SubCategories.AddAsync(subCategory);

            try
            {
                await RootRepository.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException ex)
            {
                var fault = new InvalidDbConcurrencyUpdateOpResult<SubCategoryDto>();
                return fault;
            }
            catch (DbUpdateException ex)
            {
                var fault = new InvalidDbUpdateOpResult<SubCategoryDto>();
                return fault;
            }

            var dto = SubCategoryMapper.Map<SubCategoryDto>(subCategory);
            var result = new AppOpResult<SubCategoryDto>(dto);

            return result;
        }

        public async Task<AppOpResult<SubCategoryDto>> UpdateSubCategoryAsync(SubCategoryDto attrDto)
        {
            var subCategory = SubCategoryMapper.Map<SubCategory>(attrDto);
            RootRepository.SubCategories.Update(subCategory);

            try
            {
                await RootRepository.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException ex)
            {
                var fault = new InvalidDbConcurrencyUpdateOpResult<SubCategoryDto>();
                return fault;
            }
            catch(DbUpdateException ex)
            {
                var fault = new InvalidDbUpdateOpResult<SubCategoryDto>();
                return fault;
            }

            var dto = SubCategoryMapper.Map<SubCategoryDto>(subCategory);
            var result = new AppOpResult<SubCategoryDto>(dto);

            return result;
        }

        public async Task<AppOpResult<EmptyDto>> DeleteSubCategoryAsync(string id)
        {
            var subCategory = await RootRepository.SubCategories.FindByIdAsync(id);

            if(subCategory is not null)
            {
                RootRepository.SubCategories.Remove(subCategory);

                try
                {
                    await RootRepository.SaveChangesAsync();
                }
                catch(DbUpdateConcurrencyException ex)
                {
                    var fault = new InvalidDbConcurrencyUpdateOpResult<EmptyDto>();
                    return fault;
                }
                catch(DbUpdateException ex)
                {
                    var fault = new InvalidDbUpdateOpResult<EmptyDto>();
                    return fault;
                }
            }

            var result = new AppOpResult<EmptyDto>();
            return result;
        }

        private sealed class CannotUpdateProductAttributeDueInvalidAttributeIdOpResult : AppOpResult<ProductAttributeDto>
        {
            public CannotUpdateProductAttributeDueInvalidAttributeIdOpResult() : base()
            {
                FaultResult = new AppProblemDetails
                {
                    Title = "Cannot update product attribute.",
                    Detail = "Product attribute couldn't update because there is no attribute with specified Id.",
                    StatusCode = StatusCodes.Status404NotFound,
                };
            }
        }

        private sealed class ProductNotCreatedDueInvalidAttributeIdOpResult : AppOpResult<ProductWithAdditionalInfoDto>
        {
            public ProductNotCreatedDueInvalidAttributeIdOpResult() : base()
            {
                FaultResult = new AppProblemDetails
                {
                    Title = $"{nameof(Product)} not created",
                    Detail = $"{nameof(Product)} not created because there is at least one invalid Id within received Ids.",
                    StatusCode = StatusCodes.Status404NotFound,
                };
            }
        }

        private sealed class ProductNotCreatedDueInvalidSubCategoryIdOpResult : AppOpResult<ProductWithAdditionalInfoDto>
        {
            public ProductNotCreatedDueInvalidSubCategoryIdOpResult() : base()
            {
                FaultResult = new AppProblemDetails
                {
                    Title = $"{nameof(Product)} not created",
                    Detail = $"{nameof(Product)} not created because invalid {nameof(SubCategory)} Id received.",
                    StatusCode = StatusCodes.Status404NotFound,
                };
            }
        }

        private sealed class ProductNotUpdatedDueInvalidAttributeIdOpResult : AppOpResult<ProductWithAdditionalInfoDto>
        {
            public ProductNotUpdatedDueInvalidAttributeIdOpResult() : base()
            {
                FaultResult = new AppProblemDetails
                {
                    Title = $"{nameof(Product)} not updated",
                    Detail = $"{nameof(Product)} not updated because there is at least one invalid Id within received {nameof(ProductAttribute)} Ids.",
                    StatusCode = StatusCodes.Status404NotFound,
                };
            }
        }
    }
}
