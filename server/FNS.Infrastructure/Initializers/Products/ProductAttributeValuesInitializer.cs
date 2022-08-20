using FNS.Domain.Models.Products;
using NodaTime;

namespace FNS.Infrastructure.Initializers.Products
{
    internal class ProductAttributeValuesInitializer : IDataInitializer<ProductAttributeValue>
    {
        private readonly object _locker = new object();
        private readonly IEnumerable<ProductAttributeValue> _entities;
        private readonly IEnumerable<string> _values;

        public ProductAttributeValuesInitializer()
        {
            lock (_locker)
            {
                if(_entities is not null)
                {
                    return;
                }


                string guidBasis2 = "00000000-0000-0000-0000-0000000000";
                var products = new ProductsInitializer().Entities.ToArray();
                var entities = new List<ProductAttributeValue>();

                var productAttrValues = new List<List<string>>(products.Length)
                {
                    new List<string>
                    {
                        "AMD Ryzen 5 3600 OEM",
                        "AM4",
                        2019.ToString(),
                        "6",
                        "12",
                    },
                    new List<string>
                    {
                        "AMD Ryzen 5 3600 BOX",
                        "AM4",
                        2019.ToString(),
                        "6",
                        "12",
                    },
                    new List<string>
                    {
                        "AMD Ryzen 5 4650G OEM",
                        "AM4",
                        2020.ToString(),
                        "6",
                        "12",
                    },
                    new List<string>
                    {
                        "AMD Ryzen 5 5600X OEM",
                        "AM4",
                        2020.ToString(),
                        "6",
                        "12",
                    }
                };

                
                var attributes = new ProductAttributesInitializer().Entities.ToArray();

                if(products.Length != productAttrValues.Count)
                {
                    throw new InvalidDataException();
                }

                int guidCounter = 1;

                for(int i = 0; i < products.Count(); i++)
                {
                    var product = products[i];
                    var attrValues = productAttrValues[i];

                    for(int j = 0; j < attributes.Length; j++)
                    {
                        var attrId = attributes[j].Id;
                        var attrValue = attrValues[j];
                        Guid newId;

                        if(guidCounter < 10)
                        {
                            newId = Guid.Parse(guidBasis2 + "0" + guidCounter);
                        }
                        else if(guidCounter < 100)
                        {
                            newId = Guid.Parse(guidBasis2 + guidCounter);
                        }
                        else
                        {
                            throw new NotImplementedException();
                        }

                        guidCounter++;

                        entities.Add(new ProductAttributeValue
                        {
                            Id = newId,
                            ProductId = product.Id,
                            ProductAttributeId = attrId,
                            Value = attrValue,
                        });
                    }
                }

                _entities = entities.AsReadOnly();
            }
        }

        public IEnumerable<ProductAttributeValue> Entities => _entities;

        public IEnumerable<string> Values => _values;
    }
}
