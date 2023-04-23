var cs = new CSharpStudent("Israel", 31);

cs.Routine();
// Person 'Israel' is eating.
// Student Israel keeps coding in C#.
// Student Israel rarely sleeps.

public class Person 
{
    public string name;
    public int age;
    public Person(string name, int age) 
    {
        this.name = name;
        this.age = age;
    }
    public void Eat() => Console.WriteLine($"Person '{this.name}' is eating.");
    public virtual void Work() => Console.WriteLine($"Person '{this.name}' is working.");
    public virtual void Sleep() => Console.WriteLine($"Person '{this.name}' is sleeping.");
    public void Routine()
    {
        Eat();
        Work();
        Sleep();
    }
}

public class Student : Person
{
    public Student(string name, int age) : base(name, age) {}
    public override void Work() => Console.WriteLine($"Student {this.name} goes to school.");
    public override void Sleep() => Console.WriteLine($"Student {this.name} rarely sleeps.");
}

public class CSharpStudent : Student
{
    public CSharpStudent(string name, int age) : base(name, age) {}
    public override void Work() => Console.WriteLine($"Student {this.name} keeps coding in C#.");
}
