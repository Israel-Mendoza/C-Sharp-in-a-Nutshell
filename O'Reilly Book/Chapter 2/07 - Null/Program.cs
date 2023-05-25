
/*
Reference types can be assigned 'null'. 
This only means that we are not referencing any object in particular.
*/

Point p1 = null;
Console.WriteLine(p1 == null);
// True

/*
Trying to read the attribute will raise a Runtime error:
Console.WriteLine(p1.X);

Unhandled exception. System.NullReferenceException: Object reference not set to an instance of an object.
*/

public class Point {
    public int X;
    public int Y;
}