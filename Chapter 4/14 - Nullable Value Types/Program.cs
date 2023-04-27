/*
We cannot assign a null value to a non-nullable type:

int num1 = null;
// error CS0037: Cannot convert null to 'int' because it is a non-nullable value type
*/

// Creating a nullable type out of an int:
Nullable<int> num1 = null;

// Using the GetValueOrDefault() method on the nullable type:
Console.WriteLine(num1.GetValueOrDefault());
// 0

// Another way to create a nullable out of an int:
int? num2 = null;

// Using the GetValueOrDefault() method on the nullable type:
Console.WriteLine(num2.GetValueOrDefault());
// 0
// We can ask the method to return a default value should the type be null:
Console.WriteLine(num2.GetValueOrDefault(2020));
// 2020

int? num3 = 1992;

// Using the GetValueOrDefault() method on the nullable type:
Console.WriteLine(num3.GetValueOrDefault());

// Testing for value:
Console.WriteLine(num1.HasValue);
// False
Console.WriteLine(num2.HasValue);
// False
Console.WriteLine(num3.HasValue);
// True

// Using the null-coalescing operator:
int? num4 = num1 ?? num2 ?? num3 ?? 45;
int? num5 = num1 ?? 12345;

Console.WriteLine(num4);
// 1992
Console.WriteLine(num5);
// 12345
