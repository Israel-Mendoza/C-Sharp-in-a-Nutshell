/*
    Working with classes constructors. 
    The constructor in the Student class has been overriden
    so it accepts an int as the age, and a string as the major. 
    Also created a static constructor, which will accept a long
    string containing a Student information, for instantiation.
*/

// Creating Student instances with the two constructors we defined:
var s1 = new Student("Israel");
var s2 = new Student("Victor", 27, "Computer Science");

// Creating strings out of wich we'll create Student instances:
var ss1 = "Suelen";
var ss2 = "Margarita-26-Law";
var ss3 = "Carlos-Hello-Linguistics";

// Creating Student instances with the previously created strings:
Student s3 = Student.CreateFromString(ss1);
Student s4 = Student.CreateFromString(ss2);
Student s5 = Student.CreateFromString(ss3);

// Testing the Student instances' Introduction method:
Console.WriteLine(s1.Introduction()); // Student Israel (18) studies a Major.
Console.WriteLine(s2.Introduction()); // Student Victor (27) studies Computer Science.
Console.WriteLine(s3.Introduction()); // Student Suelen (18) studies a Major.
Console.WriteLine(s4.Introduction()); // Student Margarita (26) studies Law.
Console.WriteLine(s5.Introduction()); // Student Carlos (18) studies Linguistics.

/// <summary>
/// Class <c>Student</c> models a student and their basic information.
/// </summary>
public class Student
{
    // Initializing instance fields:
    public string Name;
    int Age;
    string Major;

    /// <summary>
    /// Constructor that takes a the <param>newName</param> string
    /// as the name of the Student.
    /// </summary>
    public Student(string newName) // Constructor
    {
        Name = newName;
        Age = 18;
        Major = "a Major";
    }
    // Overloading the constructor. 
    public Student(string newName, int age, string major) : this(newName) // Calling the "original" constructor.
    {
        Age = age;
        Major = major;
    }
    /// <summary>
    /// A static constructor that take a string containing the student's information
    /// with the following format "NAME-AGE-MAJOR".
    /// It returns a <returns>Student</returns> instance.
    /// </summary>
    public static Student CreateFromString(string StudentInformation)
    {
        string Name;
        int Age;
        string Major;
        // Breaking up the StrudentInformation string into a List<string>.
        List<string> StudentInformationArray = StudentInformation.Split("-").ToList();
        if (StudentInformationArray.Count == 1) // List contains only one item.
            return new Student(StudentInformationArray[0]);
        try
        {
            Age = Int32.Parse(StudentInformationArray[1]); // Trying to create an int with the second element in the List.
        }
        catch (FormatException) // If we were unable to create an int out of the second element, the Age will default to 18.
        {
            Age = 18;
        }
        Name = StudentInformationArray[0];
        Major = StudentInformationArray[2];
        return new Student(Name, Age, Major); // Returning the new Student instance.
    }
    /// <summary>
    /// Returns a string with the Student instance's information.
    /// </summary>
    public string Introduction() => $"Student {Name} ({Age}) studies {Major}.";
}