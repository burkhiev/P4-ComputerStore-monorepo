using Microsoft.AspNetCore.Http;

namespace FNS.Domain.Utilities.OperationResults
{
    /// <summary>
    /// Класс результата операции, при которой сущность указанного типа не найдена.
    /// </summary>
    /// <typeparam name="T">Тип результата операции <see cref="OpResult<T>"/>.</typeparam>
    /// <typeparam name="TNotFoundEntity">Тип сущности, которую не удалось найти.</typeparam>
    public sealed class NotFoundResult<T, TNotFoundEntity> : OpResult<T>
    {
        public NotFoundResult() : base()
        {
            FailResult = new ProblemResultInfo
            {
                Title = $"{typeof(TNotFoundEntity).Name} entity not found",
                Detail = $"{typeof(TNotFoundEntity).Name} entity with specified Id is not found.",
                StatusCode = StatusCodes.Status404NotFound,
            };
        }
    }
}
