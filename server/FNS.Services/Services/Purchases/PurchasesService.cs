using AutoMapper;
using FNS.Domain.Exceptions;
using FNS.Domain.Models.Identity;
using FNS.Domain.Models.Purchases;
using FNS.Domain.Repositories;
using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Abstractions.Purchases;
using FNS.Services.Dtos.Purchases;
using FNS.Services.Mappers.Purchases;
using FNS.Services.Utils.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FNS.Services.Services.Purchases
{
    /// <summary>
    /// Класс сервиса, для работы с закупками (Приход).
    /// </summary>
    internal sealed class PurchasesService : IPurchasesService
    {
        private readonly IRootRepository _rootRepository;
        private readonly IMapper _mapper;

        public PurchasesService(IRootRepository rootRepository)
        {
            _rootRepository = rootRepository;
            _mapper = new PurchasesMapperConfiguration().Mapper;
        }

        public IRootRepository RootRepository => _rootRepository;
        public IMapper Mapper => _mapper;

        public async Task<OpResult<IEnumerable<PurchaseInvoiceDto>>> GetAllInvoicesAsync()
        {
            var invoices = await RootRepository.PurchaseInvoices.GetAll().ToListAsync();
            var dtos = Mapper.Map<IEnumerable<PurchaseInvoiceDto>>(invoices);

            var result = new OpResult<IEnumerable<PurchaseInvoiceDto>>(dtos);
            return result;
        }

        public async Task<OpResult<IEnumerable<PurchaseInvoiceItemWithAdditionalInfoDto>>> GetInvoiceItemsByInvoiceId(string invoiceId)
        {
            var invoice = await RootRepository.PurchaseInvoices.FindByIdAsync(invoiceId);

            if(invoice is null)
            {
                var fault = new NotFoundResult<IEnumerable<PurchaseInvoiceItemWithAdditionalInfoDto>, PurchaseInvoice>();
                return fault;
            }

            await RootRepository.PurchaseInvoices.LoadItemsWithProductsAsync(invoice.Id);

            var invoices = invoice.PurchaseInvoiceItems?.ToArray() ?? Array.Empty<PurchaseInvoiceItem>();
            var dtos = Mapper.Map<IEnumerable<PurchaseInvoiceItemWithAdditionalInfoDto>>(invoices);

            var result = new OpResult<IEnumerable<PurchaseInvoiceItemWithAdditionalInfoDto>>(dtos);
            return result;
        }

        public async Task<OpResult<PurchaseInvoiceDto>> MakePurchaseAsync(PurchaseInvoiceForCreateDto dto)
        {
            var user = await RootRepository.Users.FindByIdAsync(dto.UserId);

            if(user is null)
            {
                var notFound = new NotFoundResult<PurchaseInvoiceDto, User>();
                return notFound;
            }


            var newInvoice = new PurchaseInvoice
            {
                Id = Guid.NewGuid().ToString(),
                UserId = user.Id,
            };

            await RootRepository.PurchaseInvoices.AddAsync(newInvoice);

            foreach(var dtoItem in dto.Items)
            {
                var item = new PurchaseInvoiceItem
                {
                    Id = Guid.NewGuid().ToString(),
                    PurchaseInvoiceId = newInvoice.Id,
                    ProductId = dtoItem.ProductId,
                    Amount = dtoItem.Amount,
                };

                await RootRepository.PurchaseInvoiceItems.AddAsync(item);
            }


            try
            {
                await RootRepository.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException ex)
            {
                var errResult = new InvalidDbConcurrencyUpdateResult<PurchaseInvoiceDto>();
                return errResult;
            }
            catch(DbUpdateException ex)
            {
                var errResult = new InvalidDbUpdateResult<PurchaseInvoiceDto>();
                return errResult;
            }


            var resultDto = Mapper.Map<PurchaseInvoiceDto>(newInvoice);
            var result = new OpResult<PurchaseInvoiceDto>(resultDto);

            return result;
        }
    }
}
