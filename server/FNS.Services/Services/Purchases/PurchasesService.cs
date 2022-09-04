using AutoMapper;
using FNS.Domain.Models.Purchases;
using FNS.Domain.Repositories;
using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Abstractions.Purchases;
using FNS.Services.Dtos.Purchases;
using FNS.Services.Mappers.Purchases;
using Microsoft.AspNetCore.Http;

namespace FNS.Services.Services.Purchases
{
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

        public AppOpResult<IEnumerable<PurchaseInvoiceDto>> GetAllInvoices()
        {
            var invoices = RootRepository.PurchaseInvoices.GetAll().AsEnumerable();
            var dtos = Mapper.Map<IEnumerable<PurchaseInvoiceDto>>(invoices);

            var result = new AppOpResult<IEnumerable<PurchaseInvoiceDto>>(dtos);
            return result;
        }

        public async Task<AppOpResult<IEnumerable<PurchaseInvoiceItemDto>>> GetInvoiceItemsByInvoiceId(string invoiceId)
        {
            var invoice = await RootRepository.PurchaseInvoices.FindByIdAsync(invoiceId);

            if(invoice is null)
            {
                var fault = new PurchaseInvoiceNotFoundByIdOpResult();
                return fault;
            }

            var invoices = RootRepository.PurchaseInvoiceItems.FindByCondition(x => x.PurchaseInvoiceId == invoiceId).ToArray();
            var dtos = Mapper.Map<IEnumerable<PurchaseInvoiceItemDto>>(invoices);

            var result = new AppOpResult<IEnumerable<PurchaseInvoiceItemDto>>(dtos);
            return result;
        }

        private sealed class PurchaseInvoiceNotFoundByIdOpResult : AppOpResult<IEnumerable<PurchaseInvoiceItemDto>>
        {
            public PurchaseInvoiceNotFoundByIdOpResult() : base()
            {
                FaultResult = new AppProblemDetails
                {
                    Title = $"{nameof(PurchaseInvoiceItem)} not found",
                    Detail = $"{nameof(PurchaseInvoiceItem)} with specified Id is not found.",
                    StatusCode = StatusCodes.Status404NotFound,
                };
            }
        }
    }
}
