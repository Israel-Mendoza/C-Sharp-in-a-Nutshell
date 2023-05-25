public abstract class ProductForSale
{
    public string Type { get; set; }
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public ProductForSale(string type, decimal price, string? description = null)
    {
        Type = type;
        Price = price;
        Description = description;
    }
    public decimal GetSalesPrice(int quantity) => quantity * Price;
    public void PrintPricedItem(int quantity)
    {
        Console.WriteLine($"Price per unit: {Price}");
        Console.WriteLine($"Quantity: {quantity} units.");
        Console.WriteLine($"Total price: {GetSalesPrice(quantity):F2}");
    }
    public abstract void ShowDetails();
}