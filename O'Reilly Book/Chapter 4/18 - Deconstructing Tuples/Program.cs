using static System.Console;

var bob = (Name: "Bob", LastName: "Williams", Age: 41);

// Deconstructing the tuple by declaring and assigning values to new variables.
// Original names in the tuple must not be respected. They can be different:
(string nombre, string apellido, int edad) = bob;
WriteLine($"{nombre} {apellido} - Age: {edad}");
// Bob Williams - Age: 41

// Variables can be declared before the tuple gets deconstructed:
string prénom;
string nom;
int âge;

(prénom, nom, âge) = bob;

WriteLine($"{prénom} {nom} - Age: {âge}");
// Bob Williams - Age: 41

var mexicanBob = (nombre, apellido, edad);
var frenchBob = (prénom, nom, âge);

// Equality will be structural:
WriteLine(mexicanBob == frenchBob);
// True