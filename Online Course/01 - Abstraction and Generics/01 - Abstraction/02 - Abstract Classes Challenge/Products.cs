public class Fruit : ProductForSale
{
    public Fruit(string type, decimal price, string? description = null) : base(type, price, description)
    {
    }

    public override void ShowDetails() => Console.WriteLine($"No much to say about a {Type}");
}

public class Clothes : ProductForSale
{
    public Clothes(string type, decimal price, string? description = null) : base(type, price, description)
    {
    }

    public override void ShowDetails()
    {
        Console.WriteLine($"Piece of cloth designed and manufactured in any country in Asia.");
        Console.WriteLine($"Price: {Price:C2}. Description: {Description}");
    }
}

public class Electronics : ProductForSale
{
    public Electronics(string type, decimal price, string? description = null) : base(type, price, description)
    {
    }

    public override void ShowDetails()
    {
        Console.WriteLine($"A super {Type}, designed and manufactured somewhere you can't even imagine");
        Console.WriteLine($"Price: {Price:C2}. Description: {Description}");
    }
}