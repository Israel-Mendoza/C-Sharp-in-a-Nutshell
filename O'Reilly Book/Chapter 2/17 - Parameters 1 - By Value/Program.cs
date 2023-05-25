// PASSING ARGUMENTS BY VALUE

/*
By default, arguments are passed by value. 
A copy of the value is created when passed to the method.
However, reference types are worked on as reference types. 
*/

int myNum = 9;
Person p1 = new Person("Israel");

Increment(myNum);
// Within the function, the number is 19
Console.WriteLine(myNum);
// 9

NameChanger(p1, "Arturo");
// Israel is changing their name to Arturo
Console.WriteLine(p1.Name);
// Arturo


void Increment(int aNumber) {
    aNumber += 10;
    Console.WriteLine($"Within the function, the number is {aNumber}");
}

void NameChanger(Person aPerson, string newName) {
    string tempString = aPerson.Name;
    aPerson.Name = newName;
    Console.WriteLine($"{tempString} is changing their name to {aPerson.Name}");
}

class Person {
    public string Name;
    public Person(string newName) {
        Name = newName;
    }
}
