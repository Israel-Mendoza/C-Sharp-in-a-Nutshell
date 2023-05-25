Person p1 = new Person("Israel");
Person p2 = new Person("Israel");
Person p3 = p1;

Console.WriteLine(p1 == p2); // False
Console.WriteLine(p1 == p3); // True

public class Person {
    public string Name;
    public Person(string newName) {
        Name = newName;
    }
}