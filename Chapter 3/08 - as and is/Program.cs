// "as" will help us avoid the Casting Exception.
var p = new Person("Israel", 31);
/*
Student s = (Student)p;
Unhandled exception. System.InvalidCastException: Unable to cast object of type 'Person' to type 'Student'.
*/

// Using the "as" keyboard, we avoid the Exception. 
// If the cast fails, it'll return 'null'.
Student? s = p as Student;

/////////////////////////////////////////////////////////////////////////////

// The 'is' keyboard tests whether a variable matches a patter.
// In this context, we can test whether a variable is an instance of a given class.

var s2 = new Student("Victor", 29);


if (p is Person)
    Console.WriteLine("p is a Person instance");
else
    Console.WriteLine("p is not a Person instance");
// p is a Person instance

if (s2 is Student)
    Console.WriteLine("s2 is a Student instance");
else
    Console.WriteLine("s2 is not a Student instance");
// s2 is a Student instance

if (p is Person)
    Console.WriteLine("s2 is a Person instance");
else
    Console.WriteLine("s2 is not a Person instance");
// s2 is a Person instance


class Person
{
    public string Name;
    public int Age;
    public Person(string Name, int Age) 
    {
        this.Name = Name;
        this.Age = Age;
    }
    public virtual void Work() => Console.WriteLine($"{Name}({Age}) is working.");
}

class Student : Person
{
    public Student(string Name, int Age) : base(Name, Age) {}
    public override void Work() => Console.WriteLine($"{Name}({Age}) goes to school.");
}