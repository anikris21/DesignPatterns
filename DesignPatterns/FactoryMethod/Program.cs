using FactoryMethod;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Title = "Factory method";

var factories = new List<DiscountFactory> {
new CodeDiscountFactory(Guid.NewGuid()), new CountryDiscountFactory("US")
};

foreach (var factory in factories)
{
    var discountService = factory.CreateDiscountService();
    Console.WriteLine($"%   {discountService.DiscountPercentage} coming from {discountService}");
}
