/*
    Structs are better suited for semantically bound data, like numbers.
    This is due to the nature of the struct: a value type.
    When initialized, all fields will be set to their default value. 
    In a constructor, we must initialize all values. 
*/

var p1 = new Point(10, 5);
var points = new Point[5];

Console.WriteLine($"X={p1.X} | Y={p1.Y}");
// X=10 | Y=5

foreach (var p in points)
{
    Console.WriteLine($"X={p.X} | Y={p.Y}");
}
// X=0 | Y=0
// X=0 | Y=0
// X=0 | Y=0
// X=0 | Y=0
// X=0 | Y=0

public struct Point
{
    public int X, Y;
    public Point(int x, int y) { this.X = x; this.Y = y; }
}