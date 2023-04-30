using static System.Console;

///////////////EQUALITY COMPARISON///////////////

var name1 = "ISRAEL";
var name2 = "israel";

WriteLine(string.Equals(name1, name2, StringComparison.CurrentCulture)); // False
WriteLine(string.Equals(name1, name2, StringComparison.CurrentCultureIgnoreCase)); // True  

///////////////ORDINAL COMPARISON///////////////

/*
    String’s CompareTo instance method performs culture-sensitive, case-sensitive order comparison.
*/

var city1 = "Mexico";
var city2 = "Aguascalientes";
var city3 = "Toluca";
var city4 = "Mexico";
var city5 = "Mexico City";
var city6 = "MEXICO";

WriteLine(city1.CompareTo(city2)); // 1
WriteLine(city1.CompareTo(city3)); // -1
WriteLine(city1.CompareTo(city4)); // 0
WriteLine(city1.CompareTo(city5)); // -1
WriteLine(city1.CompareTo(city6)); // -1