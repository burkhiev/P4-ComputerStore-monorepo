using System.Drawing;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using FNS.Services.Dtos.Products;

namespace DnsParser.Parser.Dns
{
    internal sealed class DnsProductParser : IProductParser, IDisposable
    {
        private const int MaxSubCategoryProcessCount = 8;
        private const int NavigateDelayMilliseconds = 500;

        private readonly IWebDriver _driver = new ChromeDriver();

        public DnsProductParser()
        {
            _driver.Manage().Window.Size = new Size(1200, 1000);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        private IWebDriver Driver => _driver;

        public DnsProductParser(IWebDriver driver)
        {
            _driver = driver;
        }

        public List<FromFileProductDto> Parse()
        {
            Console.WriteLine("\n--------------------------------- [ Parsing started... ] ---------------------------------\n");


            string url = "https://www.dns-shop.ru/catalog/17aa522a16404e77/komplektuyushhie-dlya-pk/";
            Driver.Navigate().GoToUrl(url);
            Task.Delay(NavigateDelayMilliseconds).Wait();


            var products = ParseSubCategories(url);
            var result = new FromFileProductsDto { Products = products };


            Console.WriteLine("\n--------------------------------- [ Parsing completed ] ---------------------------------\n");

            return products;
        }

        private List<FromFileProductDto> ParseSubCategories(string returnUrl, string? subCategoryName = null)
        {
            Console.WriteLine($"\n--------------------------------- [ Parsing SubCategory... ] ---------------------------------\n");

            var products = new List<FromFileProductDto>();


            IWebElement? subCategoryElem = null;

            try
            {
                subCategoryElem = Driver.FindElement(By.ClassName("subcategory"));
            }
            catch(OpenQA.Selenium.WebDriverTimeoutException)
            {
                // nothing
            }
            catch(OpenQA.Selenium.NoSuchElementException)
            {
                // nothing
            }


            // Если блок с подкатегорией не найден, то это блок со списком продуктов
            if(subCategoryElem is null)
            {
                // Предполагается, что блок со списком продуктов открывается из страницы с подкатегориями.
                // Это значит, что subCategory is not null.
                //
                // Но на всякий пожарный
                if(subCategoryName is null)
                {
                    throw new InvalidOperationException();
                }

                ParseProductsList(subCategoryName, returnUrl);

                return products;
            }


            var subCategoriesElem = Driver.FindElement(By.ClassName("subcategory__item-container"));
            int linksCount = subCategoriesElem.FindElements(By.CssSelector(".subcategory__item.ui-link.ui-link_blue")).Count;

            if(linksCount > MaxSubCategoryProcessCount)
            {
                linksCount = MaxSubCategoryProcessCount;
            }

            for(int i = 0; i < linksCount; i++)
            {
                subCategoryElem = Driver.FindElement(By.ClassName("subcategory"));
                subCategoriesElem = subCategoryElem.FindElement(By.ClassName("subcategory__item-container"));
                var links = subCategoriesElem.FindElements(By.CssSelector(".subcategory__item.ui-link.ui-link_blue"));

                var link = links[i];

                var subCatNameElem = link.FindElement(By.ClassName("subcategory__title"));
                string subCategoryNameValue = subCatNameElem.Text.Trim();

                Console.WriteLine($"\n  SubCategory title: {subCategoryNameValue}\n");

                string curReturnUrl = Driver.Url;
                link.Click();
                Task.Delay(NavigateDelayMilliseconds).Wait();

                var subCatProducts = ParseSubCategories(curReturnUrl, subCategoryName ?? subCategoryNameValue);
                products.AddRange(subCatProducts);
            }


            Console.WriteLine($"\n--------------------------------- [ SubCategory parsed ] ---------------------------------\n");
            Driver.Navigate().GoToUrl(returnUrl);

            return products;
        }

        private List<FromFileProductDto> ParseProductsList(string subCategoryName, string returnUrl)
        {
            Console.WriteLine($"\n--------------------------------- [ Parsing Product list... ] ---------------------------------\n");

            var products = new List<FromFileProductDto>();


            var productListElem = Driver.FindElement(By.ClassName("products-list"));
            int productItemElemsCount = productListElem.FindElements(By.CssSelector(".catalog-product.ui-button-widget")).Count;

            if(productItemElemsCount > MaxSubCategoryProcessCount)
            {
                productItemElemsCount = MaxSubCategoryProcessCount;
            }

            for(int i = 0; i < productItemElemsCount; i++)
            {
                productListElem = Driver.FindElement(By.ClassName("products-list"));
                var productItemElems = productListElem.FindElements(By.CssSelector(".catalog-product.ui-button-widget"));

                var itemElem = productItemElems[i];
                var link = itemElem.FindElement(By.CssSelector(".catalog-product__name.ui-link.ui-link_black"));

                string productListUrl = Driver.Url;
                link.Click();
                Task.Delay(NavigateDelayMilliseconds).Wait();

                ParseProduct(subCategoryName, productListUrl);
            }


            Console.WriteLine($"\n--------------------------------- [ Product list parsed... ] ---------------------------------\n");

            Driver.Navigate().Back();
            //Driver.Navigate().GoToUrl(returnUrl);

            Task.Delay(NavigateDelayMilliseconds).Wait();

            return products;
        }

        private FromFileProductDto ParseProduct(string subCategoryName, string returnUrl)
        {
            Console.WriteLine($"\n--------------------------------- [ Parsing product card... ] ---------------------------------\n");


            var product = new FromFileProductDto();
            product.SubCategoryName = subCategoryName;


            var page = Driver.FindElement(By.ClassName("product-card"));
            var prodCardTop = page.FindElement(By.CssSelector(".product-card-top.product-card-top_full"));

            // Наименование
            var productNameElem = prodCardTop.FindElement(By.ClassName("product-card-top__title"));
            product.Name = productNameElem.Text.Trim();

            // Код продукта
            var prodCardCodeElem = prodCardTop.FindElement(By.ClassName("product-card-top__code"));
            product.ProductCode = prodCardCodeElem.Text.Trim().Split(' ').Last();

            // Цена
            var productPriceElem = prodCardTop.FindElement(By.ClassName("product-buy__price"));
            string rawPriceText = string.Empty;

            while(string.IsNullOrWhiteSpace(rawPriceText))
            {
                rawPriceText = productPriceElem.Text.Trim();
            }

            int currencyCharPos = 0;

            for(int i = 0; i < rawPriceText.Length; i++)
            {
                if(!char.IsDigit(rawPriceText[i]) && rawPriceText[i] != ' ')
                {
                    currencyCharPos = i;
                    break;
                }
            }

            // пропускаем символ валюты и берем цену без скидки
            string priceText = string.Empty;

            if(currencyCharPos > 0)
            {
                if(currencyCharPos == rawPriceText.Length - 1)
                {
                    priceText = rawPriceText.Substring(0, currencyCharPos);
                }
                else
                {
                    priceText = rawPriceText.Substring(currencyCharPos + 1).Trim();
                }
            }

            product.Price = decimal.Parse(priceText);


            // Открываем раздел с характеристиками
            var prodCardTabListElem = page.FindElement(By.ClassName("product-card-tabs__list"));

            bool descTabExpanded = false;
            bool descTabClicked = false;

            while(!descTabExpanded)
            {
                try
                {
                    Console.WriteLine("  Trying to click to 'Характеристики'...");

                    var descTablItemElem = prodCardTabListElem.FindElement(
                        By.CssSelector("[data-tab-name=description]"));

                    if(descTablItemElem.GetAttribute("active") is null)
                    {
                        descTablItemElem.Click();
                        descTabClicked = true;
                    }
                    
                    descTabExpanded = true;
                }
                catch(OpenQA.Selenium.ElementClickInterceptedException)
                {
                    // nothing
                }
                catch(OpenQA.Selenium.ElementNotInteractableException)
                {
                    // nothing
                }
                catch(OpenQA.Selenium.WebDriverTimeoutException)
                {
                    // nothing
                }
                catch(OpenQA.Selenium.NoSuchElementException)
                {
                    // nothing
                }
            }


            // Описание
            var prodDescBlockElem = page.FindElement(By.ClassName("product-card-description-text"));
            var prodDescElem = prodDescBlockElem.FindElement(By.TagName("p"));
            product.Description = prodDescElem.Text.Trim();


            // Специфичные атрибуты
            var attrsElem = page.FindElement(By.ClassName("product-characteristics"));

            bool groupBtnExpanded = false;
            bool expandGroupBtnClicked = false;

            while(!groupBtnExpanded)
            {
                try
                {
                    Console.WriteLine("  Trying to click to 'Развернуть все'...");

                    var expandGroupBtn = attrsElem.FindElement(
                        By.CssSelector(".button-ui.button-ui_white.product-characteristics__expand"));

                    if(expandGroupBtn.GetAttribute("active") is null)
                    {
                        expandGroupBtn.Click();
                        expandGroupBtnClicked = true;
                    }
                    
                    groupBtnExpanded = true;
                }
                catch(OpenQA.Selenium.ElementClickInterceptedException)
                {
                    // nothing
                }
                catch(OpenQA.Selenium.ElementNotInteractableException)
                {
                    // nothing
                }
                catch(OpenQA.Selenium.WebDriverTimeoutException)
                {
                    // nothing
                }
                catch(OpenQA.Selenium.NoSuchElementException)
                {
                    // nothing
                }
            }


            var attrGroupElems = attrsElem.FindElements(By.ClassName("product-characteristics__group"));

            foreach(var groupElem in attrGroupElems)
            {
                var groupTitleElem = groupElem.FindElement(By.ClassName("product-characteristics__group-title"));
                var groupTitle = groupTitleElem.Text.Trim();

                var groupItemsElems = groupElem.FindElements(By.ClassName("product-characteristics__spec"));


                foreach(var groupItemElem in groupItemsElems)
                {
                    FromFileCharacteristicDto attr = new();
                    attr.GroupTitle = groupTitle;

                    var itemNameElem = groupItemElem.FindElement(By.ClassName("product-characteristics__spec-title"));
                    attr.Name = itemNameElem.Text.Trim();

                    var itemValueElem = groupItemElem.FindElement(By.ClassName("product-characteristics__spec-value"));
                    attr.Value = itemValueElem.Text.Trim();

                    if(product.OwnAttributes is null)
                    {
                        product.OwnAttributes = new List<FromFileCharacteristicDto>();
                    }

                    product.OwnAttributes.Add(attr);
                }
            }


            Console.WriteLine(product);
            Console.WriteLine($"\n--------------------------------- [ Product card parsed... ] ---------------------------------\n");


            // Возвращаемся в список продуктов
            Console.WriteLine($"\n--------------------------------- [ Returning to list... ] ---------------------------------\n");

            if(descTabClicked)
            {
                Driver.Navigate().Back();
            }

            if(expandGroupBtnClicked)
            {
                Driver.Navigate().Back();
            }

            Driver.Navigate().Back();
            //Driver.Navigate().GoToUrl(returnUrl);

            Task.Delay(NavigateDelayMilliseconds).Wait();

            return product;
        }

        public void Dispose()
        {
            Driver.Quit();
        }
    }
}
