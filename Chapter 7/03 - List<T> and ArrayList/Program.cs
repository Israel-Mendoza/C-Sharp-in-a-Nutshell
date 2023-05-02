using static System.Console;

/*
    List<T> is generic.
    ArrayList is nongeneric.

    Unlike with arrays, all interfaces are implemented publicly, 
    and methods such as Add and Remove are exposed and work as you would expect.
*/

// Declaring an empty string. 
var words = new List<string>(); 

// Adding items to the list:
words.Add("melón");
words.Add("pera");
words.Add("manzana");
words.Add("piña");
words.AddRange(new string[] {"limón", "guayaba", "aguacate"});

// Inserting and Removing
words.Insert(0, "sandía");
words.Remove("aguacate");

foreach(var fruit in words) Write($"{fruit} ");
// sandía melón pera manzana piña limón guayaba 

// Removing all ending with "-a":
words.RemoveAll(fruit => fruit.EndsWith('a'));

WriteLine();
foreach(var fruit in words) Write($"{fruit} ");
// melón limón 

// Rebuilding
words.AddRange(new string[] { "guayaba", "sandía", "pera" });

var WORDS = words.ConvertAll(fruit => fruit.ToUpper());

WriteLine();
foreach(var fruit in WORDS) Write($"{fruit} ");
// MELÓN LIMÓN GUAYABA SANDÍA PERA 

WriteLine();
WriteLine(words.Capacity);
// 8
WriteLine(words.Count);
// 5

// SEARCHING USING METHODS
WriteLine(words.Find(fruit => fruit.StartsWith('s')));
// sandía
WriteLine(words.FindLastIndex(fruit => fruit.EndsWith('a')));
// 4
