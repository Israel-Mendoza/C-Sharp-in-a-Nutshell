using System;

int myFeet = 4;
int myInches = FeetToInches(myFeet);
Console.WriteLine(myInches);

// Calling second function
SayHello();

int FeetToInches(int feet)
{
    int inches = feet * 12;
    return inches;
}

void SayHello()
{
    Console.WriteLine("Hello, there!");
}