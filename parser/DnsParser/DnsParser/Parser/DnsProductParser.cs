using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using FNS.Services.Dtos.Products;
using DnsParser.Utilities;

namespace DnsParser.Parser
{
    internal sealed class DnsProductParser : IProductParser, IDisposable
    {
        //private const int MaxSubCategoriesProcessCount = 13;
        //private const int MaxInListProductsProcessCount = 10;
        private const int MaxInProductCardAttributesProcessCount = 20;

        private const int NavigateForwardDelayMilliseconds = 500;
        private const int NavigateBackDelayMilliseconds = 500;
        private const int RefreshDelayMilliseconds = 1000;
        private const int ImplicitWaitSeconds = 5;

        private const int MaxAttemptCount = 5;

        private readonly IWebDriver _driver = new ChromeDriver();

        public DnsProductParser()
        {
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(ImplicitWaitSeconds);
        }

        private IWebDriver Driver => _driver;

        public async Task<List<FromFileSubCategoryDto>> ParseSubCategoriesAsync(string subCategoriesUrl, int maxSubCategoriesCount)
        {
            Console.WriteLine($"  [ ... ] Navigating to {subCategoriesUrl}");

            Driver.Navigate().GoToUrl(subCategoriesUrl);

            Console.WriteLine($"  [ OK ] Navigated");



            Console.WriteLine($"  [ ... ] Parsing SubCategories");

            var subCategories = new List<FromFileSubCategoryDto>();
            var subCategoriesElem = Driver.FindElement(By.ClassName("subcategory__item-container"));
            int linksCount = subCategoriesElem.FindElements(By.CssSelector(".subcategory__item.ui-link.ui-link_blue")).Count;

            for(int i = 0; i < linksCount && i < maxSubCategoriesCount; i++)
            {
                subCategoriesElem = Driver.FindElement(By.ClassName("subcategory__item-container"));
                var links = subCategoriesElem.FindElements(By.CssSelector(".subcategory__item.ui-link.ui-link_blue"));


                var link = links[i];


                // Наименование
                var subCatNameElem = link.FindElement(By.ClassName("subcategory__title"));
                string subCatName = subCatNameElem.Text.Trim();


                // Изображение
                var pictureElem = link.FindElement(By.TagName("picture"));

                string imgUrl = pictureElem.FindElement(By.TagName("source")).GetAttribute("srcset");
                string imgData = await LoadImageAsync(imgUrl);

                string? imgExt = Path.GetExtension(imgUrl).Trim();

                while(!string.IsNullOrWhiteSpace(imgExt) && !(imgExt?.HasImageExtension() ?? false))
                {
                    int extStrLength = imgExt?.Length ?? imgUrl.Length;
                    imgUrl = imgUrl.Substring(0, imgUrl.Length - extStrLength);
                    imgExt = Path.GetExtension(imgUrl);
                }


                // Создание
                var newSubCategory = new FromFileSubCategoryDto()
                {
                    Name = subCatName,
                    Img = imgData,
                    ImgExtension = imgExt,
                };


                Console.WriteLine($"  [...] SubCategory: {newSubCategory.Name}");
                subCategories.Add(newSubCategory);
            }


            Console.WriteLine($"  [ OK ] SubCategories parsed");

            return subCategories;
        }

        public async Task<List<FromFileProductDto>> ParseProductsBySubCategoriesAsync(
            string subCategoriesUrl, 
            int maxSubCategoriesCount, 
            int maxProductsInListCount)
        {
            var options = new UriCreationOptions();

            if(!Uri.TryCreate(subCategoriesUrl, options, out Uri? uri))
            {
                throw new ArgumentException("Invalid uri received.");
            }


            Console.WriteLine($"  [ ... ] Navigating to {subCategoriesUrl}");

            Driver.Navigate().GoToUrl(subCategoriesUrl);

            Console.WriteLine($"  [ OK ] Navigated");


            var products = await ParseProductsBySubCategoriesInDepsAsync(maxSubCategoriesCount, maxProductsInListCount);
            return products;
        }

        private async Task<List<FromFileProductDto>> ParseProductsBySubCategoriesInDepsAsync(
            int maxSubCategoriesCount, 
            int maxProductsInListCount, 
            string? rootSubCategoryName = null)
        {

            List<FromFileProductDto> products = new List<FromFileProductDto>();
            bool elemWasFound = false;


            try
            {
                var subCategoriesElem = Driver.FindElement(By.ClassName("subcategory__item-container"));
                int linksCount = subCategoriesElem.FindElements(By.CssSelector(".subcategory__item.ui-link.ui-link_blue")).Count;

                Console.WriteLine($"  [ ... ] Parsing SubCategories");

                for(int i = 0; i < linksCount && i < maxSubCategoriesCount; i++)
                {
                    subCategoriesElem = Driver.FindElement(By.ClassName("subcategory__item-container"));
                    var links = subCategoriesElem.FindElements(By.CssSelector(".subcategory__item.ui-link.ui-link_blue"));


                    var link = links[i];
                    elemWasFound = true;


                    // Наименование
                    var subCatNameElem = link.FindElement(By.ClassName("subcategory__title"));
                    string subCatName = subCatNameElem.Text.Trim();

                    string linkUrl = link.GetAttribute("href");


                    Console.WriteLine($"  [ ... ] SubCategory: {subCatName}");
                    Console.WriteLine($"  [ ... ] Navigating to {linkUrl}");

                    link.Click();

                    Console.WriteLine($"  [ OK ] Navigated");

                    try
                    {
                        var subProducts = await ParseProductsBySubCategoriesInDepsAsync(
                            maxSubCategoriesCount,
                            maxProductsInListCount,
                            rootSubCategoryName ?? subCatName);

                        products.AddRange(subProducts);
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("  [ FAIL ] Error while parsing subcategory occurred.");
                    }
                }


                Console.WriteLine($"  [ OK ] SubCategories parsed");
            }
            catch(Exception)
            {
                Console.WriteLine("  [ FAIL ] Error while switching to subcategory.");
            }


            if(!elemWasFound)
            {
                try
                {
                    var productListElem = Driver.FindElement(By.ClassName("products-list"));
                    var productsFromProductList = await ParseProductsListAsync(Driver.Url, 5, rootSubCategoryName);

                    products.AddRange(productsFromProductList);

                    elemWasFound = true;
                }
                catch(Exception)
                {
                    Console.WriteLine("  [ FAIL ] Error while parsing product list occurred.");
                }
            }


            Console.WriteLine($"  [ ... ] Navigating back");

            await BackWithDelayAsync();

            Console.WriteLine($"  [ OK ] Navigated");


            return products;
        }

        public async Task<List<FromFileProductDto>> ParseProductsListAsync(
            string productListUrl, 
            int maxProductsCount, 
            string? subCategoryName = null)
        {
            var options = new UriCreationOptions();

            if(!Uri.TryCreate(productListUrl, options, out Uri? uri))
            {
                throw new ArgumentException("Invalid uri received.");
            }


            if(!Driver.Url.Equals(productListUrl, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"  [ ... ]: Navigating to {productListUrl}");

                Driver.Navigate().GoToUrl(productListUrl);

                Console.WriteLine($"  [ OK ] Navigated");
            }


            Console.WriteLine($"  [ ... ] Parsing Product list");

            var products = new List<FromFileProductDto>();

            var productListElem = Driver.FindElement(By.ClassName("products-list"));
            int productItemElemsCount = productListElem.FindElements(By.CssSelector(".catalog-product.ui-button-widget")).Count;

            for(int i = 0; i < productItemElemsCount && i < maxProductsCount; i++)
            {
                // Каждый раз создаем новый объект, связанный с элементом HTML.
                // Т.к. при возвращении из страницы товара, объекты, которые были связаны
                // с элементами списка товаров, имеют ссылки, указывающие на старые элементы.
                // 
                productListElem = Driver.FindElement(By.ClassName("products-list"));
                var productItemElems = productListElem.FindElements(By.CssSelector(".catalog-product.ui-button-widget"));

                var itemElem = productItemElems[i];
                var link = itemElem.FindElement(By.CssSelector(".catalog-product__name.ui-link.ui-link_black"));


                // Проверяем, что мы точно перешли по ссылке товара в списке
                // В некоторых случаях не переходит.
                //
                int moveAttemp = 0;

                for(; moveAttemp < MaxAttemptCount; moveAttemp++)
                {
                    string nextLinkHref = link.GetAttribute("href").Trim();
                    Console.WriteLine($"  [ ... ] Navigating to {nextLinkHref}");

                    link.Click();
                    await Task.Delay(NavigateForwardDelayMilliseconds);

                    // Перешли удачно
                    if(nextLinkHref.Equals(Driver.Url.Trim(), StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"  [ OK ] Navigated");
                        break;
                    }

                    // повторно ищем ссылку
                    productItemElems = productListElem.FindElements(By.CssSelector(".catalog-product.ui-button-widget"));
                    itemElem = productItemElems[i];
                    link = itemElem.FindElement(By.CssSelector(".catalog-product__name.ui-link.ui-link_black"));
                }

                if(moveAttemp == MaxAttemptCount)
                {
                    throw new InvalidProgramException();
                }


                FromFileProductDto? product = null;

                // парсим товар из карточки
                try
                {
                    product = await ParseProductAsync();
                }
                catch(Exception)
                {
                    Console.WriteLine(" [ FAIL ] Error while parsing product card occurred");
                }

                if(product is not null)
                {
                    product.SubCategoryName = subCategoryName;
                    products.Add(product);
                }


                Console.WriteLine($"  [ ... ] Navigating from product card");

                await BackWithDelayAsync();

                Console.WriteLine($"  [ OK ] Navigated");
            }


            Console.WriteLine($"  [ OK ] Product list parsed");

            return products;
        }
        
        private async Task<FromFileProductDto?> ParseProductAsync()
        {
            Console.WriteLine($"  [ ... ] Parsing product card");



            // Открываем раздел с характеристиками
            //
            //   В некоторых случаях, содержимое заголовка карточки зависит от активной вкладки.
            // Поэтому очень важно сначала открыть данный раздел(Характеристики),
            // т.к. иногда карточка товара открывается в других вкладках,
            // таких как: "Отзывы", "Оценка товара", и т.д.
            //
            IWebElement page = Driver.FindElement(By.ClassName("product-card"));

            bool descTabExpanded = false;
            bool descTabClicked = false;

            Console.WriteLine("  [ ... ] Trying to click to Characteristics tab");

            int attrsTabClickAttemptCount = 0;

            // Кликать на кнопку открытия характеристик, до тех пор пока
            // не откроется или не будет превышено кол-во попыток.
            for(; !descTabExpanded && attrsTabClickAttemptCount < MaxAttemptCount; attrsTabClickAttemptCount++)
            {
                Console.WriteLine($"  [ ... ] #{attrsTabClickAttemptCount + 1}");

                try
                {
                    IWebElement prodCardTabListElem = page.FindElement(By.ClassName("product-card-tabs__list"));

                    var descTablItemElem = prodCardTabListElem.FindElement(
                        By.CssSelector("[data-tab-name=description]"));

                    if(descTablItemElem.GetAttribute("active") is null)
                    {
                        Console.WriteLine("  [ ... ] Before click");

                        descTablItemElem.Click();

                        Console.WriteLine("  [ * ] After click");

                        await Task.Delay(NavigateForwardDelayMilliseconds);

                        descTabClicked = true;
                    }
                    
                    descTabExpanded = true;

                }
                catch(Exception)
                {
                    Console.WriteLine("  [ FAIL ]");
                }
            }

            // Ошибка - null
            if(attrsTabClickAttemptCount >= MaxAttemptCount)
            {
                return null;
            }

            Console.WriteLine("  [ OK ] Characteristics tab clicked");



            // Парсим общие атрибуты
            Console.WriteLine("  [ ... ] Getting common attributes ...");

            var product = new FromFileProductDto();
            bool commonAttrsAreParsed = await ParseCommonAttributesAsync(product);

            // Ошибка  - null
            if(!commonAttrsAreParsed)
            {
                return null;
            }

            Console.WriteLine("  [ OK ] Common attributes are parsed ...");



            // Раскрываем список характеристик
            Console.WriteLine("  [ ... ] Clicking on 'Развернуть все' button");

            var attrsElem = page.FindElement(By.ClassName("product-characteristics"));
            bool groupBtnExpanded = false;
            bool expandGroupBtnClicked = false;

            try
            {
                var expandGroupBtn = attrsElem.FindElement(
                    By.CssSelector(".button-ui.button-ui_white.product-characteristics__expand"));
                
                int parseAttrsAttemptCount = 0;

                // Нажимаем, пока не откроется ...
                for(; !groupBtnExpanded && parseAttrsAttemptCount < MaxAttemptCount + 5; parseAttrsAttemptCount++)
                {
                    Console.WriteLine($"  [ ... ] #{parseAttrsAttemptCount + 1}");

                    try
                    {
                        Console.WriteLine("  [ ... ] Before click");

                        expandGroupBtn.Click();
                        await Task.Delay(NavigateForwardDelayMilliseconds);

                        Console.WriteLine("  [ ... ] After click");


                        // Парсим вкладку Характеристики
                        //
                        // Попытка повторить парсинг характеристик зависит
                        // от возвращаемого результата метода ParseCharacteristicsTab()
                        //
                        var attrs = ParseCharacteristicsTab();

                        if(attrs is null)
                        {
                            // попробовать ещё ...
                            continue;
                        }

                        product.OwnAttributes = attrs;

                        expandGroupBtnClicked = true;
                        groupBtnExpanded = true;
                    }
                    catch(Exception)
                    {
                        // nothing
                    }
                }


                // Ошибка - null
                if(parseAttrsAttemptCount == MaxAttemptCount)
                {
                    return null;
                }


                Console.WriteLine("  [ OK ] \"Развернуть все\" button is clicked");
            }
            catch(Exception)
            {
                // Парсим вкладку Характеристики
                //
                // Случай, когда кнопка "Раскрыть все" отсутствует.
                // Такое бывает, когда кол-во характеристик у товара не достаточно, чтобы скрыть их.
                // 
                var attrs = ParseCharacteristicsTab();
                product.OwnAttributes = attrs ?? new List<FromFileCharacteristicDto>();
            }


            Console.WriteLine($"  [ OK ] Product card parsed");
            Console.WriteLine(product);


            // Возвращаемся в список продуктов
            if(descTabClicked)
            {
                Console.WriteLine("  [ ... ] Navigate back");

                Driver.Navigate().Back();

                Console.WriteLine("  [ OK ] Navigated");
            }

            if(expandGroupBtnClicked)
            {
                Console.WriteLine("  [ ... ] Navigate back");

                Driver.Navigate().Back();

                Console.WriteLine("  [ OK ] Navigated");
            }


            return product;
        }

        private async Task<bool> ParseCommonAttributesAsync(FromFileProductDto product)
        {
            bool propsParsed = false;
            string rawPriceText = string.Empty;

            Console.WriteLine("  [ ... ] Trying to parse product title, code, price, img.");

            int commonAttributesParseAttemptsCount = 0;

            for(; !propsParsed && commonAttributesParseAttemptsCount < MaxAttemptCount; commonAttributesParseAttemptsCount++)
            {
                Console.WriteLine($"  [ ... ] #{commonAttributesParseAttemptsCount + 1}");

                try
                {
                    IWebElement page = Driver.FindElement(By.CssSelector(".container.product-card"));
                    IWebElement prodCardTop = page.FindElement(By.CssSelector(".product-card-top.product-card-top_full"));


                    // Наименование
                    var productNameElem = prodCardTop.FindElement(By.ClassName("product-card-top__title"));
                    product.Name = productNameElem.Text.Trim();

                    if(product.Name.EndsWith('.'))
                    {
                        product.Name = product.Name.Substring(0, product.Name.Length - 1);
                    }


                    // Код продукта
                    var prodCardCodeElem = prodCardTop.FindElement(By.ClassName("product-card-top__code"));
                    product.ProductCode = prodCardCodeElem.Text.Trim().Split(' ').Last();


                    // Цена. Поиск сырой строки
                    var productPriceElem = prodCardTop.FindElement(By.ClassName("product-buy__price"));

                    while(string.IsNullOrWhiteSpace(rawPriceText))
                    {
                        rawPriceText = productPriceElem.Text.Trim();
                    }

                    // Цена. Разбор сырой строки
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


                    // Описание
                    var prodDescBlockElem = page.FindElement(By.ClassName("product-card-description-text"));
                    var prodDescElem = prodDescBlockElem.FindElement(By.TagName("p"));
                    product.Description = prodDescElem.Text.Trim();


                    // Изображение
                    var imgSliderMainElem = prodCardTop.FindElement(By.ClassName("product-images-slider__main"));
                    var imgElem = imgSliderMainElem.FindElement(By.TagName("source"));

                    string imgUrl = imgElem.GetAttribute("srcset");
                    string imgData = await LoadImageAsync(imgUrl);

                    string? imgExt = Path.GetExtension(imgUrl);

                    while(!string.IsNullOrWhiteSpace(imgExt) && !(imgExt?.HasImageExtension() ?? false))
                    {
                        int extStrLength = imgExt?.Length ?? imgUrl.Length;
                        imgUrl = imgUrl.Substring(0, imgUrl.Length - extStrLength);
                        imgExt = Path.GetExtension(imgUrl);
                    }

                    product.Img = imgData;
                    product.ImgExtension = imgExt;


                    propsParsed = true;
                }
                catch(Exception)
                {
                    Console.WriteLine("  [ FAIL ]");
                    await RefreshWithDelayAsync();
                }
            }

            if(commonAttributesParseAttemptsCount >= MaxAttemptCount)
            {
                return false;
            }


            Console.WriteLine("  [ OK ] Product title, code, price are parsed.");

            return true;
        }

        private List<FromFileCharacteristicDto>? ParseCharacteristicsTab()
        {
            Console.WriteLine("  [ ... ] Parsing own characteristics");


            IWebElement page = Driver.FindElement(By.ClassName("product-card"));


            // Специфичные атрибуты
            var attrsElem = page.FindElement(By.ClassName("product-characteristics"));
            var attrGroupElems = attrsElem.FindElements(By.ClassName("product-characteristics__group"));

            List<FromFileCharacteristicDto> attrs = new();


            for(int i = 0; i < attrGroupElems.Count && i < MaxInProductCardAttributesProcessCount; i++)
            {
                var groupElem = attrGroupElems[i];

                var groupTitleElem = groupElem.FindElement(By.ClassName("product-characteristics__group-title"));
                var groupTitle = groupTitleElem.Text;

                var groupItemsElems = groupElem.FindElements(By.ClassName("product-characteristics__spec"));


                foreach(var groupItemElem in groupItemsElems)
                {
                    FromFileCharacteristicDto attr = new();
                    attr.Group = groupTitle;

                    var itemNameElem = groupItemElem.FindElement(By.ClassName("product-characteristics__spec-title"));
                    attr.Name = itemNameElem.Text;

                    var itemValueElem = groupItemElem.FindElement(By.ClassName("product-characteristics__spec-value"));
                    attr.Value = itemValueElem.Text;


                    if(string.IsNullOrWhiteSpace(attr.Group) || string.IsNullOrWhiteSpace(attr.Name))
                    {
                        return null;
                    }


                    attr.Group = attr.Group.Trim();
                    attr.Name = attr.Name.Trim();
                    attr.Value = attr.Value.Trim();


                    if(attr.Value.Equals("нет", StringComparison.OrdinalIgnoreCase)
                        || attr.Value.Equals("-", StringComparison.OrdinalIgnoreCase))
                    {
                        attr.Value = null;
                    }


                    attrs.Add(attr);
                }
            }


            Console.WriteLine("  [ OK ] Own characteristics parsed");

            return attrs;
        }

        private async Task<string> LoadImageAsync(string url)
        {
            if(string.IsNullOrWhiteSpace(url))
            {
                return string.Empty;
            }

            var client = new HttpClient();

            byte[] data = await client.GetByteArrayAsync(url);
            string convertedData = Convert.ToBase64String(data);

            return convertedData;
        }

        private async Task RefreshWithDelayAsync()
        {
            Driver.Navigate().Refresh();
            await Task.Delay(RefreshDelayMilliseconds);
        }

        private async Task BackWithDelayAsync()
        {
            Driver.Navigate().Back();
            await Task.Delay(NavigateBackDelayMilliseconds);
        }

        public void Dispose()
        {
            Driver.Quit();
        }
    }
}
