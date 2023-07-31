// allow an abstraction over factory classes
using AbstractFactory.CatalogFactory;
using AbstractFactory;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


IEnumerable<Lawnmower> mowers = new LawnmowerCatalogAbstractFactory()
.CreateCatalogFactory("toyota")
.CreateCatalog("Diesel")
.GetLawnmowers();

foreach (var m in mowers)
{
    Console.WriteLine(m.Name);
}

Console.ReadKey();


