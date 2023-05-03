using static System.Console;

/*
    HashSet<T> and SortedSet<T> have the following distinguishing features: 
    • Their Contains methods execute quickly using a hash-based lookup.
    • They do not store duplicate elements and silently ignore requests to add duplicates.
    • You cannot access an element by position.
*/

var letters = new HashSet<char>("Eu sempre quis aprender C# pra encontrar um bom emprego.");

foreach (var letter in letters) Write(letter);
// Eu semprqiandC#cotbg.

WriteLine();
WriteLine(letters.Contains('é')); // False
WriteLine(letters.Contains('h')); // False
WriteLine(letters.Contains('#')); // True

letters.UnionWith("áéíóú");

foreach (var letter in letters) Write(letter);
// Eu semprqiandC#cotbg.áéíóú
WriteLine();

letters.ExceptWith("aeiouáéíóú .,;?!#$&%"); // Removing vowels, spaces and special signs

foreach (var letter in letters) Write(letter);
// EsmprqndCctbg
