public class Product
{
    public string? Name { get; set; }
    public decimal Price { get; set; }
    private int discountPercentage;
    public int DiscountPercentage
    {
        get => discountPercentage;
        set
        {
            if (value > 50)
                discountPercentage = 50;
            else
                discountPercentage = value;
        }
    }
    public Product(string name, decimal initialPrice) { Name = name; Price = initialPrice; }
    public override string ToString()
    {
        return $"{Name} at {Price:C2}. Discount of {DiscountPercentage}%";
    }
}
