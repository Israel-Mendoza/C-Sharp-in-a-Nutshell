var p = new Student("Israel");



public class Student {
    public string Name;
    int Age;
    string Major;
    public Student(string newName) {
        Name = newName;
    }

    public Student(string newName, int age, string major) : this (newName) {
        Age = age;
        Major = major;
    }
}