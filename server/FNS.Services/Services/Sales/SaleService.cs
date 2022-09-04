using AutoMapper;
using FNS.Domain.Models.SalesReceipts;
using FNS.Domain.Repositories;
using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Abstractions.SalesReceipts;
using FNS.Services.Dtos.SalesReceipts;
using FNS.Services.Mappers.SalesReceipts;
using Microsoft.AspNetCore.Http;

namespace FNS.Services.Services.Sales
{
    internal sealed class SaleService : ISalesReceiptService
    {
        private readonly IRootRepository _rootRepository;
        private readonly IMapper _mapper;

        public SaleService(IRootRepository rootRepository)
        {
            _rootRepository = rootRepository;
            _mapper = new SalesReceiptsMapperConfiguration().Mapper;
        }

        public IRootRepository RootRepository => _rootRepository;

        public IMapper Mapper => _mapper;

        public AppOpResult<IEnumerable<SalesReceiptDto>> GetAll()
        {
            var receiptes = RootRepository.SalesReceiptRepository.GetAll().ToArray();
            var dtos = Mapper.Map<IEnumerable<SalesReceiptDto>>(receiptes);

            var result = new AppOpResult<IEnumerable<SalesReceiptDto>>(dtos);
            return result;
        }

        public async Task<AppOpResult<SalesReceiptWithAdditionalInfoDto>> GetWithAdditionalAsync(string id, CancellationToken ct = default)
        {
            var receipt = await RootRepository.SalesReceiptRepository.FindByIdAsync(id, ct);

            if(receipt is null)
            {
                var errResult = new SalesReceiptNotFoundResult();
                return errResult;
            }

            await RootRepository.SalesReceiptWithProductRepository.LoadAdditionalInfoBySalesReceiptId(receipt.Id, ct);

            var dtos = Mapper.Map<SalesReceiptWithAdditionalInfoDto>(receipt);
            var result = new AppOpResult<SalesReceiptWithAdditionalInfoDto>(dtos);

            return result;
        }

        private sealed class SalesReceiptNotFoundResult : AppOpResult<SalesReceiptWithAdditionalInfoDto>
        {
            public SalesReceiptNotFoundResult()
            {
                ProblemDetails = new AppProblemDetails
                {
                    Title = $"{typeof(SalesReceipt).Name} not found",
                    Detail = $"{typeof(SalesReceipt).Name} with specified Id is not found",
                    StatusCode = StatusCodes.Status404NotFound,
                };
            }
        }
    }
}
