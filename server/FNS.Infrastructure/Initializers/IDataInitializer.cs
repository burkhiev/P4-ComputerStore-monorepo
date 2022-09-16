using FNS.Domain.Models;

namespace FNS.ContextsInfrastructure.Initializers
{
    internal interface IDataInitializer<T> where T : class, new()
    {
        IEnumerable<T> Entities { get; }
    }
}
