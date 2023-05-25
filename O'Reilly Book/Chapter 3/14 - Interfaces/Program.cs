void MakeAnimalMakeSound(IAnimal animal) => animal.MakeSound();
void MakeSpeakerSpeak(ISpeaker speaker) => speaker.Speak();
void MakeSupremeBeingBeSupreme(ISupremeBeing supremeBeing)
{
    supremeBeing.Speak();
    supremeBeing.Think();
}

var d = new Dog();
var p = new Pig();
var h = new Human("Israel", 31);
var sb = new Person("Israel", 31, "Spanish");

MakeAnimalMakeSound(d);
// Whoof, whoof, motherfucker!
MakeAnimalMakeSound(p);
// Cuiiiiii! Cuiiiiii! :(
MakeAnimalMakeSound(h);
// This human sample called Israel speaks.


MakeSpeakerSpeak(h);
// This human sample called Israel speaks.
MakeSupremeBeingBeSupreme(sb);
// People tend to think they actually think. Just like Israel! LOL!

interface IAnimal
{
    void MakeSound();
    void Move();
}

interface ISpeaker
{
    void Speak();
}

interface ISupremeBeing : IAnimal, ISpeaker
{
    string Language { get; set; }
    void Think();
}

class Dog : IAnimal
{
    public void MakeSound() => Console.WriteLine("Whoof, whoof, motherfucker!");
    public void Move() => Console.WriteLine("The dog moved waving his talil!");
}

class Pig : IAnimal
{
    public void MakeSound() => Console.WriteLine("Cuiiiiii! Cuiiiiii! :(");
    public void Move() => Console.WriteLine("The pig moves in the mud.");
}

class Human : IAnimal, ISpeaker
{
    public string Name;
    public int Age;
    public Human(string Name, int Age)
    {
        this.Name = Name;
        this.Age = Age;
    }
    public void MakeSound() => this.Speak();
    public void Move() => Console.WriteLine("A human can walk and run.");
    public void Speak() => Console.WriteLine($"This human sample called {Name} speaks.");
}

class Person : ISupremeBeing
{
    public string Name;
    public int Age;
    public Person(string Name, int Age, string Language)
    {
        this.Name = Name;
        this.Age = Age;
        this.Language = Language;
    }
    public string Language { get; set; }
    public void MakeSound() => this.Speak();
    public void Move() => Console.WriteLine("A human can walk and run.");
    public void Speak() => Console.WriteLine($"This human sample called {Name} speaks {Language}.");
    public void Think() => Console.WriteLine($"People tend to think they actually think. Just like {Name}! LOL!");
}