using DnsParser.Parser.Dns;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;


new DriverManager().SetUpDriver(new ChromeConfig());


using(var parser = new DnsProductParser())
{
    var products = parser.Parse();
}


Console.ReadLine();
