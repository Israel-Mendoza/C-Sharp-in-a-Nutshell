using static System.Console;

var bob = (Name: "Bob", LastName: "Williams", Age: 41);

WriteLine(bob.Item1 + " " + bob.Name);
// Bob Bob
WriteLine(bob.Item2 + " " + bob.LastName);
// Williams Williams
WriteLine(bob.Item3 + " " + bob.Age);
// 41 41

var john = GetGenericPerson();
WriteLine($"{john.Name} {john.LastName} - {john.Age}");
// John Doe - 18

var now = DateTime.Now;
var nowTuple = (now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second);
WriteLine($"It's {nowTuple.Hour}:{nowTuple.Minute}:{nowTuple.Second}");
// It's 21:1:36

// Named tuple as a Method return type:
(string Name, string LastName, int Age) GetGenericPerson() => (Name: "John", LastName: "Doe", Age: 18);