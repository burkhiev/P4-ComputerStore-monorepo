using FNS.Domain.Models;

namespace FNS.Infrastructure.Initializers
{
    internal interface IDataInitializer<T> where T : EntityBase, new()
    {
        IEnumerable<T> Entities { get; }
    }
}
