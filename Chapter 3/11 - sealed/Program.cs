var p = new Person();
var s = new Student();
var cs = new CollegeStudent();

p.Work();
// Person is working...
s.Work(); // Overriden
// Student is studying hard...
cs.Work(); // Hidden
// Student is drinking.

Person ps = s;
Person pcs = cs;

p.Work();
// Person is working...
ps.Work(); // Overriden
// Student is studying hard...
pcs.Work(); // Hidden. 
// Student is studying hard...

class Person
{
    public virtual void Work() => Console.WriteLine("Person is working...");
}

class Student : Person
{
    public sealed override void Work() => Console.WriteLine("Student is studying hard...");
}

/*
class CollegeStudent : Student
{
    // Trying to override the sealed method will result in the following
    // compile error:
    // CollegeStudent.Work()': cannot override inherited member 'Student.Work()' because it is sealed .
    public override void Work() => Console.WriteLine("Student is drinking.");
}
*/

// But we can hide it... LOL!

class CollegeStudent : Student
{
    // Trying to override the sealed method will result in the following
    // compile error:
    // CollegeStudent.Work()': cannot override inherited member 'Student.Work()' because it is sealed .
    public new void Work() => Console.WriteLine("Student is drinking.");
}