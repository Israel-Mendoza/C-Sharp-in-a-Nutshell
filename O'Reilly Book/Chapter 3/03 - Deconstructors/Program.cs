// Working with the Deconstructor method to get values from the instance.

var rec = new Rectangle(7.5, 10.5);
rec.PrintDescription();
// Rectangle with width: 7.5 and height: 10.5 has an area of 78.75

// Deconstructing:
(double w1, double h1) = rec;

rec.PrintDescription();
// Rectangle with width: 7.5 and height: 10.5 has an area of 78.75

Console.WriteLine(w1);
// 7.5
Console.WriteLine(h1);
// 10.5

// Deconstructing using the actual method:
double w2;
double h2;
rec.Deconstruct(out w2, out h2);

Console.WriteLine(w2);
// 7.5
Console.WriteLine(h2);
// 10.5

// Deconstructing using the actual method, 
// but declaring the variables when calling the method:
rec.Deconstruct(out double w3, out double h3);
Console.WriteLine(w3);
// 7.5
Console.WriteLine(h3);
// 10.5

class Rectangle
{
    public readonly double Width;
    public readonly double Height;

    public Rectangle(double width, double height) // Constructor
    {
        Width = width;
        Height = height;
    }

    public double Area() // Method to get the area of the rectangle
    {
        return Width * Height;
    }
    // Method to print the description of the rectangle:
    public void PrintDescription() => Console.WriteLine($"Rectangle with width: {Width} and height: {Height} has an area of {Area()}");

    // Deconstruct method:
    public void Deconstruct(out double width, out double height)
    {
        width = Width;
        height = Height;
    }
}