using FNS.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FNS.Infrastructure.Abstractions
{
    internal interface IAppEntityTypeConfiguration<T> : IEntityTypeConfiguration<T>
        where T : EntityBase, new()
    {
        void SharedConfigureActions(EntityTypeBuilder<T> builder);
    }
}
