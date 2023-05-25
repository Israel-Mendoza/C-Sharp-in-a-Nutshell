/*
    GetType called on an object returns the type (class) it was instantiated from.
    The typeof function will return the type of a class.
*/

var p = new Person("Israel");

Console.WriteLine(p.GetType().Name);
// Person
Console.WriteLine(typeof(Person).Name);
// Person
Console.WriteLine(p.GetType() == typeof(Person));
// True

Console.WriteLine(p.Name.GetType().Name);
// String
Console.WriteLine(p.Name.GetType().FullName);
// System.String

class Person
{
    public string Name;
    public Person(string Name)
    {
        this.Name = Name;
    }
}