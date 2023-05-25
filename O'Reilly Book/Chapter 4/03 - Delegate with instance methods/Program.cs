//////////////////USING THE DELEGATE TO WRAP THE INSTANCE METHOD//////////////////
var p1 = new Person("Israel", 31);
var p2 = new Person("Margarita", 29);

// Creating delegate with an instance method bound to an instance.
var d1 = new Introducer(p1.IntroducePerson);

d1();
// Hello, my name is Israel and I'm 31 years old.

// Adding a second method:
d1 += p2.IntroducePerson;

d1();
// Hello, my name is Israel and I'm 31 years old.
// Hello, my name is Margarita and I'm 29 years old.


////////////////////DEFINING CLASS (AND METHODS) AND A DELEGATE////////////////////
class Person
{
    public string Name;
    public int Age;
    public Person(string Name, int Age) { this.Name = Name; this.Age = Age; }
    public void IntroducePerson() => Console.WriteLine($"Hello, my name is {Name} and I'm {Age} years old.");
}

delegate void Introducer();