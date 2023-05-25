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
        var priceStr = $"{GetSalesPrice(quantity):C2}";
        var line = $"{quantity,5} | {Type,12} | {priceStr,12} | '{Description}'";
        Console.WriteLine(line);
    }
    public abstract void ShowDetails();
}