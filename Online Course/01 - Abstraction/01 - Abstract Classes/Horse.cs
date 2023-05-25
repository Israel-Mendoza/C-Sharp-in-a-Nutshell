class Horse : Mammal
{
    public Horse(string type, string size, double weight) : base(type, size, weight) { }

    protected override string? Type { get; set; }

    internal override void MakeNoise() => Console.WriteLine($"The {this.ExplicitType} ('{Type}') says 'Neeeeigh'");
    internal override void Move(string speed)
    {
        if (speed == "slow")
            Console.WriteLine($"The {this.ExplicitType} is jogging");
        else
            Console.WriteLine($"Look how fast the horse is running!");
    }

    internal override void ShedHair()
    {
        Console.WriteLine($"The {this.ExplicitType} does not lose hairs...");
    }
}