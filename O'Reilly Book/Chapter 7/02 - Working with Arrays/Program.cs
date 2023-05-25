using static System.Console;

// SEARCHING
/*
    We can use the Array methods to search for information in an array.

    We have some methods, like:
        BinarySearch
        Find
        FindAll
        FindIndex
        FindLast
        FindLastIndex
*/

var p1 = new Person("Israel", 31);
var p2 = new Person("Sebastian", 32);
var p3 = new Person("Antonia", 31);
var p4 = new Person("Moises", 31);
var p5 = new Person("Arturo", 74);
var p6 = new Person("Victor", 29);

var people = new Person[] { p1, p2, p3, p4, p5, p6 };

var searchedAge = 32;

// Defining the Predicate<T> function to be used by the FindLast:
bool GetAge31(Person p) => p.Age == searchedAge;

// Using the finding method:
Person? lastPersonAged31 = Array.FindLast(people, GetAge31);
Person? personAged29 = Array.Find(people, p => p.Age == 29);
Person[] peopleAged31 = Array.FindAll(people, p => p.Age == 31);

if (lastPersonAged31 == null)
    WriteLine($"We don't have people aged {searchedAge}.");
else
    WriteLine(lastPersonAged31);

if (personAged29 == null)
    WriteLine($"We don't have people aged {searchedAge}.");
else
    WriteLine(personAged29);

if (peopleAged31.Length == 0)
    WriteLine($"We don't have people aged {searchedAge}.");
else
{
    WriteLine("\nPeople aged 31:");
    foreach (Person p in peopleAged31)
    {
        WriteLine(p);
    }
}

class Person
{
    public string? Name { set; get; }
    public int Age { set; get; }
    public Person(string Name, int Age)
    {
        this.Name = Name;
        this.Age = Age;
    }
    public override string ToString()
    {
        return $"Person called '{Name}' is {Age} years old.";
    }
}
