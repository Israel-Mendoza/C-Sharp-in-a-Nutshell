var prod1 = new Product("Jarritos de Tamarindo", 28.90M);

prod1.DiscountPercentage = 15;

// Using extension method:
Console.WriteLine($"{prod1.GetPriceWithDiscount():C2}");
// $24.57
prod1.PrintProductInformation();
// Name: Jarritos de Tamarindo
// Price: $28.90
// Discount: 15%
