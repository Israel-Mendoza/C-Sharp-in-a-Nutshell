/*
    Abstract classes provide the methods/members a subclass must implement.
    We cannot set fields as abstract, since they are not to be "implemented".
    Abstract classes can also contain fully implemented methods as well.
*/

void Introducing(Person p) => p.Introduce();

var s = new Student("Israel", 31);

Introducing(s);
// Salut! Je m'apelle Israel et j'ai 31 ans.

public abstract class Person
{
    // Setting abstract methods/properties.
    public abstract string Name { get; }
    public abstract int Age { get; }
    public abstract void Introduce();
    // Implementing full method.
    public void Work() => Console.WriteLine($"{Name} is working now...");
}

public class Student : Person
{
    string name;
    int age;
    public Student(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    // Complying with the abstract class' methods:
    public override string Name { get => this.name; }
    public override int Age { get => this.age; }
    public override void Introduce() => Console.WriteLine($"Salut! Je m'apelle {Name} et j'ai {Age} ans.");
}