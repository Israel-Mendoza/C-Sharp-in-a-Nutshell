// Working with custom types.

UnitConverter feetToInches = new UnitConverter(12);
UnitConverter milesToFeet = new UnitConverter(5280);

int feet = 5;
int inches = feetToInches.Convert(feet);

int miles = 260;
int feet2 = milesToFeet.Convert(miles);

Console.WriteLine($"{feet} feet equals {inches} inches.");
// 5 feet equals 60 inches.
Console.WriteLine($"{miles} miles equals {feet2} feet.");
// 260 miles equals 1372800 feet.

///////////////////////////////////////////////////////////

Person p1 = new Person("Israel Mendoza");
Person p2 = new Person("Victor Bocanegra");

p1.SayHello();
// Israel Mendoza is saying hello!
p2.SayHello();
// Victor Bocanegra is saying hello!

Person.PersonSayHello();
// A Person knows how to say hello.

///////////////////////////////////////////////////////////

Panda pn1 = new Panda("Pan Dee");
Panda pn2 = new Panda("Pan Dah");

Console.WriteLine(pn1.Name);
// Pan Dee
Console.WriteLine(pn2.Name);
// Pan Dah
Console.WriteLine(Panda.Population);
// 2


///////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////

public class UnitConverter {
    int ratio; // Private instance member.

    // Constructor
    public UnitConverter(int unitRatio) { 
        ratio = unitRatio;
    }

    // Inscance method.
    public int Convert(int unit) {
        return unit * ratio;
    }
}

public class Person {
    public string fullName; // Public instance member.

    // Constructor:
    public Person(string newFullName) {
        fullName = newFullName;
    }

    // Instance method:
    public void SayHello() {
        Console.WriteLine($"{fullName} is saying hello!");
    }
    // Static method:
    public static void PersonSayHello() {
        Console.WriteLine($"A Person knows how to say hello.");
    }
}

public class Panda {
    public string Name; // Public instance member.
    public static int Population; // Public static member.
    
    // Constructor
    public Panda (string newName) {
        Name = newName; // Initializing the 'Name' instance member.
        Population = Population + 1; // Increasing the class static member.
    }

}
