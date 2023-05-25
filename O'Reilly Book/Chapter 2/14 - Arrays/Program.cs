// Arrays

char[] vowels = new char[5]; // Give me an array made up of 5 characters.

vowels[0] = 'a';
vowels[1] = 'e';
vowels[2] = 'i';
vowels[3] = 'o';
vowels[4] = 'u';

char[] vowels2 = new char[5] {'a', 'e', 'i', 'o', 'u'};
char[] vowels3 = {'a', 'e', 'i', 'o', 'u'};

for (int i = 0; i < vowels.Length; i++) {
    Console.Write(vowels[i]);
}
Console.WriteLine();
// aeiou

for (int i = 0; i < vowels2.Length; i++) {
    Console.Write(vowels2[i]);
}
Console.WriteLine();
// aeiou

for (int i = 0; i < vowels3.Length; i++) {
    Console.Write(vowels3[i]);
}
Console.WriteLine();
// aeiou

/////////////////////////////////////////////////////////////////////////////

// DEFAULT INITIALIZATION

int[] myNums = new int[1000];
double[] myDecimals = new double[1000];
string[] myWords = new string[1000];
Person[] myPeople = new Person[1000];
Person2[] myVIP = new Person2[1000];
Person2[] myVIP2 = new Person2[1000];
for (int i = 0; i < myVIP2.Length; i++) {
    myVIP2[i] = new Person2();
}
// Arrays are reference types, so they can be "null":
int[] placeholder = null;

// Default values for value objects:
Console.WriteLine(myNums[123]);
// 0
Console.WriteLine(myDecimals[123]);
// 0
Console.WriteLine($"'{myWords[123]}'");
// ''
Console.WriteLine(myPeople[123].Age);
// 0
Console.WriteLine(myVIP[123].Age);
// Unhandled exception. System.NullReferenceException: Object reference not set to an instance of an object.
Console.WriteLine(myVIP2[123].Age);
// 0 (Each instance of Person2 was created and assigned to each element in the array).

public struct Person {
    public int Age;
}

public class Person2 {
    public int Age;
}