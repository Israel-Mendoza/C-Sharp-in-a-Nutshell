public class OrderItem
{
    public int Quantity { get; set; }
    public ProductForSale Product { get; set; }
    public OrderItem(int quantity, ProductForSale product)
    {
        Quantity = quantity;
        Product = product;
    }
    public decimal FinalPrice { get => Quantity * Product.Price; }
    public void PrintItem()
    {
        Product.PrintPricedItem(Quantity);
    }
}