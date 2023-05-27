class Dog : Animal
{
    protected override string? Type { get; set; }
    internal Dog(string type, string size, double weight) : base(type, size, weight) { }

    internal override void MakeNoise()
    {
        if (Type == "Wolf")
            Console.WriteLine("Aooooooooooo");
        else
            Console.WriteLine("Woof!");
    }

    internal override void Move(string speed)
    {
        string movementType = speed == "slow" ? "walking..." : "running!";
        Console.WriteLine($"The {this.ExplicitType} is {movementType}");
    }
}