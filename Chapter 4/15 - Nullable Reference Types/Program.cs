/*
    By default, and before C# 8, only Value Types could be nullables.
    Reference types were, by default, nullables, but explicit definition
    made it difficult to debug Null Exceptions.

    From C# 8 onwards, we have the option to ask the IDE to explicitly 
    request reference types to be set as Nullable Types.

    This is done in the project csproj file:
    <Nullable>enable</Nullable>

    Benefits:

    + Allows the programmer to clearly show their intent when declaring variables.
    + Provides protection against null reference exceptions.
    + The compiler warns you if you dereference a nullable reference when it may be null.
*/

var p = new Person();
Console.WriteLine(p.Name?.Length); // If it's not null, get the Length of the property.
//

p.Name = "Israel";
Console.WriteLine(p.Name!.Length); // I know what I'm doing! Trust me when I say this is not null!
// 6

var u1 = new User<int>(12345);
var u2 = new User<string?>("12345"); // Compiler is giving me a warning already!
// warning CS8714: The type 'string?' cannot be used as type parameter 'T' in the generic type 
// or method 'User<T>'. Nullability of type argument 'string?' doesn't match 'notnull' constraint.
class Person
{
    public string? Name { get; set; }
    public int Age { get; set; }
}

class User<T> where T : notnull // The Generic Type must be notnullable
{
    public string? Name { get; set; }
    public T ID { get; set; }
    public User(T ID) { this.ID = ID; }
}