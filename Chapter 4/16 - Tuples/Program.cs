using static System.Console;

var bob = ("Bob", "Williams", 43);

// Checking the type:
WriteLine(bob.GetType());
// System.ValueTuple`3[System.String,System.String,System.Int32]
WriteLine(bob);
// (Bob, Williams, 43)

// Accesing the contents of the tuple:
WriteLine(bob.Item1);
// Bob
WriteLine(bob.Item2);
// Williams
WriteLine(bob.Item3);
// 43


// Tuples are value types with mutable elements

var joe = bob;
joe.Item1 = "Joe";
joe.Item2 = "Martinez";

WriteLine(bob);
// (Bob, Williams, 43)
WriteLine(joe);
// (Joe, Martinez, 43)

//////////////SPECIFYING TUPLE TYPE//////////////

(string, string, int) ben = ("Ben", "Johnson", 31);
WriteLine(ben.GetType());
// System.ValueTuple`3[System.String,System.String,System.Int32]

// Getting a tuple out of a method:
var john = GetPerson();
WriteLine(john);
// (John, Doe, 18)

// Setting a method that will return a tuple
(string, string, int) GetPerson() => ("John", "Doe", 18);