public class Fruit : ProductForSale
{
    public Fruit(string type, decimal price, string? description = null) : base(type, price, description)
    {
    }

    public override void ShowDetails()
    {
        throw new NotImplementedException();
    }
}

public class Clothes : ProductForSale
{
    public Clothes(string type, decimal price, string? description = null) : base(type, price, description)
    {
    }

    public override void ShowDetails()
    {
        throw new NotImplementedException();
    }
}

public class Electronics : ProductForSale
{
    public Electronics(string type, decimal price, string? description = null) : base(type, price, description)
    {
    }

    public override void ShowDetails()
    {
        throw new NotImplementedException();
    }
}