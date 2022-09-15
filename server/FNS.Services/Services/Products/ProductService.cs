using System.Net.Mime;
using System.Text.Json;
using AutoMapper;
using FNS.Domain.Exceptions;
using FNS.Domain.Models.Balances;
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

        public OpResult<IEnumerable<ProductDto>> GetAllProducts()
        {
            var products = RootRepository.Products.GetAll().ToArray();
            var productsDtos = ProductMapper.Map<IEnumerable<ProductDto>>(products);

            var result = new OpResult<IEnumerable<ProductDto>>(productsDtos);
            return result;
        }

        public OpResult<IEnumerable<ProductDto>> GetProductsBySubCategoryId(string subCategoryId)
        {
            var products = RootRepository.Products
                .FindByCondition(product => product.SubCategoryId == subCategoryId);
            var productsDtos = ProductMapper.Map<IEnumerable<ProductDto>>(products);

            var result = new OpResult<IEnumerable<ProductDto>>(productsDtos);
            return result;
        }

        public async Task<OpResult<ProductWithAdditionalInfoDto>> GetProductWithAdditionalInfoByIdAsync(string id)
        {
            var product = await RootRepository.Products.FindByIdAsync(id);

            if(product is null)
            {
                var notFoundResult = new NotFoundResult<ProductWithAdditionalInfoDto, Product>();
                return notFoundResult;
            }

            await RootRepository.Products.LoadAttributesAndTheirValuesAsync(product);

            var dto = ProductMapper.Map<ProductWithAdditionalInfoDto>(product);
            var result = new OpResult<ProductWithAdditionalInfoDto>(dto);

            return result;
        }

        public async Task<OpResult<ProductWithAdditionalInfoDto>> CreateProduct(ProductForCreateDto dto)
        {
            // добавление продукта
            var product = ProductMapper.Map<Product>(dto);
            product.Id = Guid.NewGuid().ToString();

            await RootRepository.Products.AddAsync(product);


            // создание счета для продукта
            var productBalacnce = new ProductBalance
            {
                Id = Guid.NewGuid().ToString(),
                ProductId = product.Id,
                Amount = 0,
            };

            await RootRepository.ProductBalances.AddAsync(productBalacnce);


            // добавление значений доп. атрибутов для продукта (все что не входит в модель Product)
            foreach(var attrValue in dto.AdditionalAttributes)
            {
                var newAttrValue = new ProductAttributeValue
                {
                    Id = Guid.NewGuid().ToString(),
                    ProductId = product.Id,
                    ProductAttributeId = attrValue.Key,
                    Value = attrValue.Value?.ToString()
                };

                await RootRepository.ProductWithAttributeValues.AddAsync(newAttrValue);
            }


            await RootRepository.SaveChangesAsync();

            var newDto = ProductMapper.Map<ProductWithAdditionalInfoDto>(product);
            var result = new OpResult<ProductWithAdditionalInfoDto>(newDto);

            return result;
        }

        public async Task<OpResult<ProductWithAdditionalInfoDto>> UpdateProduct(ProductWithAdditionalInfoDto dto)
        {
            var product = await RootRepository.Products.FindByIdAsync(dto.Id);

            if (product is null)
            {
                var notFound = new NotFoundResult<ProductWithAdditionalInfoDto, Product>();
                return notFound;
            }


            ProductMapper.Map(dto, product);
            RootRepository.Products.Update(product);


            // удаление отсутствующих значений доп. атрибутов
            var attrIds = dto.AdditionalAttributes.Select(x => x.Id);
            var allAttrs = RootRepository.ProductAttributes.GetAll().ToList();

            var curAttrValues = RootRepository.ProductWithAttributeValues
                .FindByCondition(x => x.ProductId == product.Id)
                .ToList();


            // сравнение: что было, что стало
            var attrsForDeleting = curAttrValues.ExceptBy(attrIds, x => x.Id);

            foreach(var attr in attrsForDeleting)
            {
                RootRepository.ProductWithAttributeValues.Remove(attr);
            }


            // изменение/добавление полученных значений доп. атрибутов
            bool someAttrIsNotFound = false;

            foreach(var receivedAttr in dto.AdditionalAttributes)
            {
                var attrsValues = curAttrValues.Where(x => x.ProductAttributeId == receivedAttr.Id).ToList();

                if(attrsValues.Count() == 0)
                {
                    var attrValue = new ProductAttributeValue
                    {
                        Id = Guid.NewGuid().ToString(),
                        ProductId = product.Id,
                        ProductAttributeId = receivedAttr.Id,
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
                var notFoundResult = new NotFoundResult<ProductWithAdditionalInfoDto, ProductAttribute>();
                return notFoundResult;
            }


            // Фиксация изменений
            try
            {
                await RootRepository.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException ex)
            {
                var fault = new InvalidDbConcurrencyUpdateResult<ProductWithAdditionalInfoDto>();
                return fault;
            }
            catch(DbUpdateException ex)
            {
                var fault = new InvalidDbUpdateResult<ProductWithAdditionalInfoDto>();
                return fault;
            }


            var newProduct = await RootRepository.Products.FindByIdAsync(product.Id);
            var productDto = ProductMapper.Map<ProductWithAdditionalInfoDto>(product);
            var result = new OpResult<ProductWithAdditionalInfoDto>(productDto);

            return result;
        }

        public async Task<OpResult<EmptyDto>> DeleteProductAsync(string id)
        {
            var product = await RootRepository.Products.FindByIdAsync(id);

            if(product is not null)
            {
                RootRepository.Products.Remove(product);
                await RootRepository.SaveChangesAsync();
            }

            var result = new OpResult<EmptyDto>();
            return result;
        }

        public OpResult<IEnumerable<ProductAttributeDto>> GetAllProductAttributes()
        {
            var attributes = RootRepository.ProductAttributes.GetAll().ToList();
            var dtos = ProductAttributeMapper.Map<IEnumerable<ProductAttributeDto>>(attributes);

            var result = new OpResult<IEnumerable<ProductAttributeDto>>(dtos);
            return result;
        }

        public async Task<OpResult<ProductAttributeDto>> CreateProductAttributeAsync(ProductAttributeForCreateDto attrDto)
        {
            var attr = ProductAttributeMapper.Map<ProductAttribute>(attrDto);
            attr.Id = Guid.NewGuid().ToString();

            var newAttr = await RootRepository.ProductAttributes.AddAsync(attr);
            await RootRepository.SaveChangesAsync();

            var dto = ProductAttributeMapper.Map<ProductAttributeDto>(newAttr);
            var result = new OpResult<ProductAttributeDto>(dto);

            return result;
        }

        public async Task<OpResult<ProductAttributeDto>> UpdateProductAttribute(ProductAttributeDto attrDto)
        {
            var attribute = ProductAttributeMapper.Map<ProductAttribute>(attrDto);
            RootRepository.ProductAttributes.Update(attribute);


            try
            {
                await RootRepository.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException ex)
            {
                var fault = new InvalidDbConcurrencyUpdateResult<ProductAttributeDto>();
                return fault;
            }
            catch(DbUpdateException ex)
            {
                var fault = new InvalidDbUpdateResult<ProductAttributeDto>();
                return fault;
            }


            var newAttrDto = ProductAttributeMapper.Map<ProductAttributeDto>(attribute);
            var result = new OpResult<ProductAttributeDto>(newAttrDto);

            return result;
        }

        public async Task<OpResult<EmptyDto>> DeleteProductAttributeAsync(string id)
        {
            var attribute = await RootRepository.ProductAttributes.FindByIdAsync(id);

            if(attribute is not null)
            {
                RootRepository.ProductAttributes.Remove(attribute);
                await RootRepository.SaveChangesAsync();
            }

            var result = new OpResult<EmptyDto>();
            return result;
        }

        public OpResult<IEnumerable<SubCategoryDto>> GetAllSubCategories()
        {
            var subCategories = RootRepository.SubCategories.GetAll().ToList();
            var dtos = SubCategoryMapper.Map<IEnumerable<SubCategoryDto>>(subCategories);

            var result = new OpResult<IEnumerable<SubCategoryDto>>(dtos);
            return result;
        }

        public async Task<OpResult<SubCategoryDto>> CreateSubCategoryAsync(SubCategoryForCreateDto attrDto)
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
                var fault = new InvalidDbConcurrencyUpdateResult<SubCategoryDto>();
                return fault;
            }
            catch (DbUpdateException ex)
            {
                var fault = new InvalidDbUpdateResult<SubCategoryDto>();
                return fault;
            }

            var dto = SubCategoryMapper.Map<SubCategoryDto>(subCategory);
            var result = new OpResult<SubCategoryDto>(dto);

            return result;
        }

        public async Task<OpResult<SubCategoryDto>> UpdateSubCategoryAsync(SubCategoryDto attrDto)
        {
            var subCategory = SubCategoryMapper.Map<SubCategory>(attrDto);
            RootRepository.SubCategories.Update(subCategory);

            try
            {
                await RootRepository.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException ex)
            {
                var fault = new InvalidDbConcurrencyUpdateResult<SubCategoryDto>();
                return fault;
            }
            catch(DbUpdateException ex)
            {
                var fault = new InvalidDbUpdateResult<SubCategoryDto>();
                return fault;
            }

            var dto = SubCategoryMapper.Map<SubCategoryDto>(subCategory);
            var result = new OpResult<SubCategoryDto>(dto);

            return result;
        }

        public async Task<OpResult<EmptyDto>> DeleteSubCategoryAsync(string id)
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
                    var fault = new InvalidDbConcurrencyUpdateResult<EmptyDto>();
                    return fault;
                }
                catch(DbUpdateException ex)
                {
                    var fault = new InvalidDbUpdateResult<EmptyDto>();
                    return fault;
                }
            }

            var result = new OpResult<EmptyDto>();
            return result;
        }

        public async Task<OpResult<EmptyDto>> LoadProductsFromJson(IFormFile file)
        {
            if(file is null || file.ContentType != MediaTypeNames.Application.Json)
            {
                var badResult = new BadRequestResult<EmptyDto>();
                return badResult;
            }


            // Десериализация полученных данных
            FromFileProductsDto? productsDto = null;

            using(var stream = file.OpenReadStream())
            {
                var jsonOptions = new JsonSerializerOptions
                { 
                    AllowTrailingCommas = true, 
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                };

                productsDto = await JsonSerializer.DeserializeAsync<FromFileProductsDto>(stream, jsonOptions);
            }


            if(productsDto is null)
            {
                var empty = new OpResult<EmptyDto>();
                return empty;
            }



            // добавление продуктов и их подкатегорий
            Dictionary<string, SubCategory> subCategories = new();
            Dictionary<string, ProductAttribute> productAttributes = new();
            Dictionary<string, ProductAttributeGroup> productAttributeGroups = new();

            foreach(var productDto in productsDto.Products)
            {
                bool hasProductWithName = await RootRepository.Products
                    .FindByCondition(x => x.Name.Equals(productDto.Name, StringComparison.OrdinalIgnoreCase))
                    .AnyAsync();


                // ***** Упрощение *****
                //
                // Если уже существует товар с указанным именем, то пропускаем его добавление.
                if(hasProductWithName)
                {
                    continue;
                }



                // Поиск/создание подкатегории для товара
                string subCategoryName = string.Empty;
                SubCategory? subCategory = null;

                // поиск
                if(!subCategories.TryGetValue(subCategoryName, out subCategory))
                {
                    subCategory = await RootRepository.SubCategories
                        .FindByCondition(x => x.Name == subCategoryName)
                        .FirstAsync();


                    // создание
                    if(subCategory is null)
                    {
                        subCategory = new SubCategory
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = subCategoryName,
                        };

                        await RootRepository.SubCategories.AddAsync(subCategory);
                    }

                    subCategories.Add(subCategory.Name, subCategory);
                }



                // Создание товара
                var product = ProductMapper.Map<Product>(productDto);
                product.Id = Guid.NewGuid().ToString();
                product.SubCategoryId = subCategory.Id;

                await RootRepository.Products.AddAsync(product);



                // Начало добавления атрибутов товара
                foreach(var attrDto in productDto.OwnAttributes)
                {
                    // Поиск/создание группы атрибута
                    ProductAttributeGroup? attrGroup = null;

                    // поиск
                    if(!productAttributeGroups.TryGetValue(attrDto.Group, out attrGroup))
                    {
                        attrGroup = RootRepository.ProductAttributeGroups
                            .FindByCondition(x => x.Name.Equals(attrDto.Group, StringComparison.OrdinalIgnoreCase))
                            .First();

                        // создание
                        if(attrGroup is null)
                        {
                            attrGroup = new ProductAttributeGroup
                            {
                                Id = Guid.NewGuid().ToString(),
                                Name = attrDto.Group,
                            };

                            await RootRepository.ProductAttributeGroups.AddAsync(attrGroup);
                        }

                        productAttributeGroups.Add(attrDto.Group, attrGroup);
                    }


                    // Поиск/создание атрибута
                    ProductAttribute? attr = null;

                    // поиск
                    if(!productAttributes.TryGetValue(attrDto.Name, out attr))
                    {
                        attr = RootRepository.ProductAttributes
                            .FindByCondition(x => x.Name.Equals(attrDto.Name, StringComparison.OrdinalIgnoreCase))
                            .First();

                        // создание
                        if(attr is null)
                        {
                            attr = new ProductAttribute
                            {
                                Id = Guid.NewGuid().ToString(),
                                Name = attrDto.Name,
                                ClrType = typeof(string).Name,
                                GroupId = attrGroup.Id,
                            };

                            await RootRepository.ProductAttributes.AddAsync(attr);
                        }

                        productAttributes.Add(attrDto.Name, attr);
                    }


                    // ***** Упрощение *****
                    //
                    // Т.к. предполагается пропуск товара, который имеет наименование, уже добавленного товара,
                    // то на этом шаге гарантируется уникальность комбинации [товар, атрибут, значение атрибута].
                    ProductAttributeValue attrValue = new()
                    {
                        Id = Guid.NewGuid().ToString(),
                        ProductId = product.Id,
                        ProductAttributeId = attr.Id,
                    };

                    await RootRepository.ProductWithAttributeValues.AddAsync(attrValue);
                }
                // Конец добавления атрибутов товара

            }


            await RootRepository.SaveChangesAsync();
            // Конец добавления товаров


            var result = new OpResult<EmptyDto>();
            return result;
        }
    }
}
