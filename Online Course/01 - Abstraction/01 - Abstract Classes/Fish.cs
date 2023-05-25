class Fish : Animal
{
    protected override string? Type { get; set; }
    internal Fish(string type, string size, double weight) : base(type, size, weight) { }

    internal override void MakeNoise()
    {
        if (Type == "Goldfish")
            Console.WriteLine("Gloo gloo...");
        else
            Console.WriteLine("Splash!");
    }

    internal override void Move(string speed)
    {
        if (speed == "slow")
            Console.WriteLine($"The {this.ExplicitType} is swimming lazily...");
        else
            Console.WriteLine($"The {this.ExplicitType} is flying under water!");
    }
}