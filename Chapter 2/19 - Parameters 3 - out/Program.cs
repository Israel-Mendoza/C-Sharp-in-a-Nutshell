// USING out

/*
Similar to 'ref' with two differences:

1. It not need be assigned before entering the function. 
2. Must be assigned before going out of the function.
*/

string a, b, firstName;

string myName = "Israel Mendoza";
nameSetter(myName, out a, out b);

Console.WriteLine($"My name is {a} {b}.");
// My name is Israel Mendoza.

// Discarding values with an underscore.
nameSetter(myName, out firstName, out _);
Console.WriteLine($"My name is {firstName}!");
// My name is Israel!

void nameSetter(string fullName, out string firstName, out string lastName) {
    string[] names = fullName.Split(' ');
    firstName = names[0];
    lastName = names[1];
}