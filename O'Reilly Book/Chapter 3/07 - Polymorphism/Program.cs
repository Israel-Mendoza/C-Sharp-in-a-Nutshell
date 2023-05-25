// Any subclass of Person will inherit the Introduce method.
void GetIntroduction(Person p) => p.Introduce();

// Any subclass of Student will inherit the Study method.
void MakeStudentStudy(Student s) => s.Study();

// Creating instances of base class, and subclasses:
var p = new Person("Arturo", 71);
var s = new Student("Israel", 31);
var cs = new CollegeStudent("Victor", 29);

// Using the GetIntroduction with classes and subclasses.
GetIntroduction(p);
GetIntroduction(s);
GetIntroduction(cs);
// Hello, my name is Arturo and I'm 71 years old.
// Hello, my name is Israel and I'm 31 years old.
// Hello, my name is Victor and I'm 29 years old.

// Using the MakeStudentStudy with classes and subclasses.
MakeStudentStudy(s);
MakeStudentStudy(cs);
// Israel is studying...
// Victor is studying...


///////////////////////////////////////////////////////////////
////////////////////////////CASTING////////////////////////////
///////////////////////////////////////////////////////////////

///////////////////////////UPCASTING///////////////////////////

// We can "upcast" implicitly.
// Ex. Assign a subclass instance (like CollegeStudent) to a class instance (like Person):
Person personStudent = cs;

// Verifying that both instances () are pointing to the same object:
Console.WriteLine($"{cs.GetType()} - {personStudent.GetType()}");
// CollegeStudent - CollegeStudent
Console.WriteLine($"{cs == personStudent}");
// True

// We can only call methods defined at base class level:
personStudent.Introduce();
// Hello, my name is Victor and I'm 29 years old.

/*
But we can't call methods defined at subclass level:

personStudent.Study();
Compile error:
'Person' does not contain a definition for 'Study' 
and no accessible extension method 'Study' accepting 
a first argument of type 'Person' could be found 
(are you missing a using directive or an assembly reference?)
*/

///////////////////////////DOWNCASTING/////////////////////////

// When downcasting, we must do it explicitly.
// Ex. Assign a class instance (like Person) to a subclass instance (like CollegeStudent):
/*
CollegeStudent studentPerson = (CollegeStudent)p;
Unhandled exception. System.InvalidCastException: Unable to cast object of type 'Person' to type 'CollegeStudent'.
*/

public class Person
{
    public string Name;
    public int Age;
    // Constructor
    public Person (string Name, int Age)
    {
        this.Name = Name;
        this.Age = Age;
    }
    public void Introduce() => Console.WriteLine($"Hello, my name is {Name} and I'm {Age} years old.");
}

public class Student : Person
{
    public Student (string Name, int Age) : base(Name, Age) {}
    public void Study() => Console.WriteLine($"{Name} is studying...");
}

public class CollegeStudent : Student
{
    public CollegeStudent (string Name, int Age) : base(Name, Age) {}
}
