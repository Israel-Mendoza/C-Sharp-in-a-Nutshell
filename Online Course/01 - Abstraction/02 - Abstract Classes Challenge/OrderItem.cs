public class OrderItem
{
    public int Quantity { get; set; }
    public ProductForSale Product { get; set; }
    public OrderItem(int quantity, ProductForSale product)
    {
        Quantity = quantity;
        Product = product;
    }
}