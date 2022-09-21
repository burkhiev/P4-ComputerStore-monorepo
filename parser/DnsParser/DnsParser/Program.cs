using System.Diagnostics;
using DnsParser.Parser;
using DnsParser.Utilities;
using FNS.Services.Dtos.Products;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;


new DriverManager().SetUpDriver(new ChromeConfig());



Console.WriteLine("\n  -------------------------- [ Simple parser ] --------------------------\n");

string? key = string.Empty;

while(!(key.StartsWith('s') || key.StartsWith('S')
    || key.StartsWith('p') || key.StartsWith('P')
    || key.StartsWith('a') || key.StartsWith('A')))
{
    Console.WriteLine("  [ ... ] Enter \"s\" key if you want parse Sub Categories");
    Console.WriteLine("  [ ... ] Enter \"p\" key if you want parse Product list");
    Console.WriteLine("  [ ... ] Enter \"a\" key if you want parse Product list by Sub Categories");
    Console.WriteLine("  [ ... ] Enter \"q\" key for quit");

    Console.Write("  [ KEY ]: ");

    key = Console.ReadLine();

    if(!string.IsNullOrWhiteSpace(key) && key.StartsWith('q') || key.StartsWith('Q'))
    {
        Console.WriteLine("\n  [ ... ] Exiting\n  ");
        await Task.Delay(500);
        return;
    }

    Console.WriteLine();
}


string? startingUrl = null;

Console.WriteLine("  [ ... ] Please, enter starting URL for parsing");
Console.Write("  [ URL ]: ");

startingUrl = Console.ReadLine();



var watcher = new Stopwatch();
watcher.Start();

string dirPath = @"C:\Users\burhi\OneDrive\Рабочий стол\Projects\P4-ComputerStore-monorepo\";

bool success = false;


try
{
    if(key.StartsWith('s') || key.StartsWith('S'))
    {
        var subCategories = new FromFileSubCategoriesDto();

        using(var parser = new DnsProductParser())
        {
            startingUrl = startingUrl ?? "https://www.dns-shop.ru/catalog/17aa522a16404e77/komplektuyushhie-dlya-pk/";

            subCategories.SubCategories = await parser.ParseSubCategoriesAsync(startingUrl, maxSubCategoriesCount: 13);
        }

        var fileWriter = new CustomFileWriter();
        await fileWriter.WriteToFileAsync(dirPath, "sub-categories", subCategories);

        success = true;
    }
    else if(key.StartsWith('p') || key.StartsWith('P'))
    {
        var products = new FromFileProductsDto();

        using(var parser = new DnsProductParser())
        {
            startingUrl = startingUrl ?? "https://www.dns-shop.ru/catalog/17a899cd16404e77/processory/";

            products.Products = await parser.ParseProductsListAsync(startingUrl, maxProductsCount: 10);
        }

        var fileWriter = new CustomFileWriter();
        await fileWriter.WriteToFileAsync(dirPath, "products", products);

        success = true;
    }
    else if(key.StartsWith('a') || key.StartsWith('A'))
    {
        var products = new FromFileProductsDto();

        using(var parser = new DnsProductParser())
        {
            startingUrl = startingUrl ?? "https://www.dns-shop.ru/catalog/17aa522a16404e77/komplektuyushhie-dlya-pk/";

            products.Products = await parser.ParseProductsBySubCategoriesAsync(
                subCategoriesUrl: startingUrl,
                maxSubCategoriesCount: 3,
                maxProductsInListCount: 5);
        }

        var fileWriter = new CustomFileWriter();
        await fileWriter.WriteToFileAsync(dirPath, "products-with-subcategories", products);

        success = true;
    }
    else
    {
        throw new NotImplementedException();
    }
}
catch(Exception)
{
    // nothing
}


watcher.Stop();

if(success)
{
    Console.WriteLine();
    Console.WriteLine("  [ ********************************************************** ] ");
    Console.WriteLine("  [ *** ] Parsing completed");
    Console.WriteLine($"  [ *** ] Time elapsed: {watcher.Elapsed}");
    Console.WriteLine("  [ ********************************************************** ] ");
    Console.WriteLine();
}
else
{
    Console.WriteLine();
    Console.WriteLine("  [ ********************************************************** ] ");
    Console.WriteLine("  [ *** ] Error while parsing occured");
    Console.WriteLine($"  [ *** ] Time elapsed: {watcher.Elapsed}");
    Console.WriteLine("  [ ********************************************************** ] ");
    Console.WriteLine();
}

Console.WriteLine("  [ ... ] Press any key to exit...\n\n\n\n\n\n\n");
Console.ReadKey();
