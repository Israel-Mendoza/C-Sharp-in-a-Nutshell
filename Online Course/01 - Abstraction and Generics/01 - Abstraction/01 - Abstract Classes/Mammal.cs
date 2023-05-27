abstract class Mammal : Animal
{
    internal Mammal(string type, string size, double weight) : base(type, size, weight)
    {
    }
    internal abstract void ShedHair();
}