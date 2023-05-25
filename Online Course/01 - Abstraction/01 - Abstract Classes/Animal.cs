abstract class Animal
{
    protected abstract string? Type { get; set; }
    private string size;
    private double weight;
    internal string ExplicitType { get => $"{this.GetType()} ('{Type}')"; }
    internal Animal(string type, string size, double weight)
    {
        this.Type = type;
        this.size = size;
        this.weight = weight;
    }
    internal abstract void Move(string speed);
    internal abstract void MakeNoise();
    // internal abstract void ShedHair();
}