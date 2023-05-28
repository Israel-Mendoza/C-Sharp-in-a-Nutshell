// The new methods must be within a new class, which MUST be static.

public static class ProductExtensions
{
    // The extension method must also be static.
    // The first parameter must be "this" + the name of the targe class + the parameter name
    public static decimal GetPriceWithDiscount(this Product productInstance)
    {
        // We cannot use the "this" keyword. But that why we gave the Product instance a name:
        var result = (productInstance.Price * ((decimal)(100 - productInstance.DiscountPercentage) / 100));
        return result;
    }
    public static void PrintProductInformation(this Product product)
    {
        Console.WriteLine($"Name: {product.Name}\nPrice: {product.Price:C2}\nDiscount: {product.DiscountPercentage}%");
    }
}
