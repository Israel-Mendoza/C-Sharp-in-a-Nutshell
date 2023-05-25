// USING ref TO PASS BY REFERENCE

/*
We can ask the program to work on the same memory location, 
instead of creating copies of value types.
*/

string myName = "Israel";
int age = 25;
int five = 5;
int twelve = 12;

nameChanger(ref myName, "Arturo");
// Israel is changing their name to Arturo
birthday(ref age);
// Someone is turning 26!
intSwapper(ref five, ref twelve);

Console.WriteLine(myName);
// Arturo
Console.WriteLine(age);
// 26
Console.WriteLine($"Five: {five} - Twelve: {twelve}");
// Five: 12 - Twelve: 5

void nameChanger(ref string aName, string newName) {
    Console.WriteLine($"{aName} is changing their name to {newName}");
    aName = newName;
}

void birthday(ref int anAge) {
    Console.WriteLine($"Someone is turning {++anAge}!");
}

void intSwapper(ref int a, ref int b) {
    int tempA = a;
    a = b;
    b = tempA;
}