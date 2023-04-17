// USING THE var KEYWORD

/*
When it is obvious what type we're initializing,
we can use the 'var' keyword instead.
*/

var Name = "Israel";
var Age = 32;
var IsHandsome = true;
var p1 = new Person("Israel");
var p2 = new Panda(true);

Console.WriteLine(Name.GetTypeCode());
// String
Console.WriteLine(Age.GetTypeCode());
// Int32
Console.WriteLine(IsHandsome.GetTypeCode());
// Boolean
Console.WriteLine(p1.GetType());
// Person
Console.WriteLine(p2.GetType());
// Panda

// USING THE new KEYWORD to initialize objects

Person p3 = new ("Arturo");
Panda p4 = new (true);

Console.WriteLine(p3.GetType());
// Person
Console.WriteLine(p4.GetType());
// Panda

class Person {
    string Name;
    public Person(string newName) {
        Name = newName;
    }
}

class Panda {
    bool isBornOutOfChina;
    public Panda(bool bornOutOfChina) {
        isBornOutOfChina = bornOutOfChina;
    }
}