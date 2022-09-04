using FNS.Domain.Enums.Measures;
using FNS.Domain.Models.Products;
using FNS.ContextsInfrastructure.Initializers.Products;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Linq.Expressions;
using FNS.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace FNS.ContextsInfrastructure.Configurations.Products
{
    internal sealed class ProductAttributesConfiguration : IEntityTypeConfiguration<ProductAttribute>
    {
        public const int MaxNameLength = 100;
        public const int MaxMeasureLength = 50;

        public void Configure(EntityTypeBuilder<ProductAttribute> builder)
        {
            EntityBaseConfigurator.ConfigureDefault(builder);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(MaxNameLength);

            builder.Property(p => p.Measure)
                .HasMaxLength(MaxMeasureLength);

            builder.Property(p => p.ClrType)
                .IsRequired();

            var init = new ProductAttributesInitializer();
            builder.HasData(init.Entities);
        }

        /// <summary>
        /// (Устарел) Предназначен для валидации <see cref="ProductAttribute.Measure"/>.
        /// </summary>
        [Obsolete]
        private class LengthUnitsConverter : ValueConverter
        {
            protected LengthUnitsConverter(LambdaExpression convertToProviderExpression, LambdaExpression convertFromProviderExpression, ConverterMappingHints? mappingHints = null)
            : this(convertToProviderExpression, convertFromProviderExpression, convertsNulls: false, mappingHints)
            {
                // do nothing
            }

            protected LengthUnitsConverter(LambdaExpression convertToProviderExpression, LambdaExpression convertFromProviderExpression, bool convertsNulls, ConverterMappingHints? mappingHints = null)
                : base(convertToProviderExpression, convertFromProviderExpression, mappingHints)
            {
                // do nothing
            }

            public override Func<object?, object?> ConvertToProvider => ConvertTo;

            public override Func<object?, object?> ConvertFromProvider => ConvertFrom;

            public override Type ModelClrType => typeof(LengthUnits);

            public override Type ProviderClrType => typeof(string);

            public static LengthUnitsConverter Converter => new LengthUnitsConverter(() => DoNothing(), () => DoNothing());

            private object? ConvertTo(object? value)
            {
                if(value is null)
                {
                    throw new InvalidDataException();
                }

                var enumVal = (LengthUnits)value;
                var raw = Enum.GetName(enumVal);

                if(raw is null)
                {
                    throw new InvalidDataException();
                }

                if(raw == Enum.GetName(LengthUnits.None))
                {
                    return null;
                }

                return raw;
            }

            private object? ConvertFrom(object? value)
            {
                if(value is null)
                {
                    return LengthUnits.None;
                }

                var raw = (string)value;

                if(!Enum.TryParse(raw, out LengthUnits result))
                {
                    throw new InvalidDataException();
                }

                return result;
            }

            /// <summary>
            /// Метод для передачи в конструктор класса <see cref="LengthUnitsConverter"/>.
            /// Конструктор класса <see cref="LengthUnitsConverter"/> требует передачи экземпляра класса <see cref="LambdaExpression"/>.
            /// Однако <see cref="LambdaExpression"/> не может иметь "statement body", например: <code>() => { }</code>
            /// Поэтому необходимо передать метод-заглушку.
            /// </summary>
            private static void DoNothing() { }
        }
    }
}
