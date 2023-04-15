/*
VALUE TYPES

Value types are simply values. 
When passed to a function, the values are copied.
Same when assigned to a new variable.
*/

int i = 10;
int j = i;
i = 20;
Console.WriteLine($"i = {i}, j = {j}");
// i = 20, j = 10

Point p1 = new Point();
p1.X = 10;
p1.Y = 20;
Point p2 = p1;
p2.X = 100;
p2.Y = 200;

Console.WriteLine($"p1.X = {p1.X} - p1.Y = {p1.Y}");
// p1.X = 10 - p1.Y = 20
Console.WriteLine($"p2.X = {p2.X} - p2.Y = {p2.Y}");
// p2.X = 100 - p2.Y = 200

/*
REFERENCE TYPES

Reference types are references to an object. 
Assigning a reference-type variable copies the reference, not the object instance.
This allows multiple variables to refer to the same object—something not ordinarily
possible with value types.
*/

Pointv2 p3 = new Pointv2();
p3.X = 10;
p3.Y = 20;
Pointv2 p4 = p3;
p4.X = 100;
p4.Y = 200;

// Both variables point to the same object:
Console.WriteLine($"p3.X = {p3.X} - p3.Y = {p3.Y}");
// p3.X = 100 - p3.Y = 200
Console.WriteLine($"p4.X = {p4.X} - p4.Y = {p4.Y}");
// p4.X = 100 - p4.Y = 200

// Structs are value types
public struct Point {
    public int X;
    public int Y;
}

// Classes are reference types
public class Pointv2 {
    public int X;
    public int Y;
}