// The "this" keyword.

var i = new Person("Israel", 31);
var s = new Person("Suelen", 32);

i.Introduce();
// I'm Israel, I'm 31 years old and I am NOT married.
s.Introduce();
// I'm Suelen, I'm 32 years old and I am NOT married.

i.Marry(s);
// Congratulations, Israel and Suelen!

i.Introduce();
// I'm Israel, I'm 31 years old, and I'm married to Suelen.
s.Introduce();
// I'm Suelen, I'm 32 years old, and I'm married to Israel.

class Person
{
    string name;
    int age;
    Person? partner;
    public Person(string name, int age)
    {
        this.name = name; // To differenciate from the argument and the field.
        this.age = age; // To differenciate from the argument and the field.
    }
    public void Marry(Person partner)
    {
        this.partner = partner; // Who is who? We use "this" to differenciate.
        partner.partner = this;
        Console.WriteLine($"Congratulations, {this.name} and {partner.name}!");
    }
    public void Introduce()
    {
        if (partner == null)
            Console.WriteLine($"I'm {name}, I'm {age} years old and I am NOT married.");
        else
            Console.WriteLine($"I'm {name}, I'm {age} years old, and I'm married to {partner.name}.");
    }

}