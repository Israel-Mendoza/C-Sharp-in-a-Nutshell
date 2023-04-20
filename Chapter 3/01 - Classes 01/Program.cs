// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine(Octopus.Message);
var o = new Octopus("George");
o.IntroduceItself();


class Octopus
{
    // Defining fields:
    string name;
    public int Age = 10;
    public static string Message = "Hello from the sea!";

    public Octopus(string newName) => name = newName; // Constructor. 

    public void IntroduceItself() => Console.WriteLine($"Hi, my name is {name}.");

    // Cannot overload methods where the return type (and the params keyword is used) are not part of the method signature:
    // public string IntroduceItself() => $"Hi, my name is {name}." <<< Compile error.
}