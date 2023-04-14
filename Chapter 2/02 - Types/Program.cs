// Integers. int is the default type for numeric literals.
int x = 12 * 15;
Console.WriteLine(x);
// 180

// Strings.
string aMessage = "Hello, World!";
string upperMessage = aMessage.ToUpper();
Console.WriteLine(aMessage);
// Hello, World!
Console.WriteLine(upperMessage);
// HELLO, WORLD!
Console.WriteLine(x.ToString());
// 180

// Booleans. 
bool simpleVar = false;
if (simpleVar)
{
    Console.WriteLine("This will not print.");
}
// Nothing prints.

int aNumber = 5000;
bool lessThanAMile = aNumber < 5280;
if (lessThanAMile)
{
    Console.WriteLine("This will print.");
}
// This will print.