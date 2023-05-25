using static System.Console;

var myDict = new Dictionary<int, string>();

myDict.Add(1, "uno");
myDict.Add(2, "dos");
myDict.Add(3, "tres");
myDict.Add(4, "cuatro");
myDict[5] = "cinco";
myDict[6] = "seis";

WriteLine(myDict[4]); // cuatro
try
{
    WriteLine(myDict[7]);
}
catch (KeyNotFoundException kex)
{
    WriteLine(kex);
}
// System.Collections.Generic.KeyNotFoundException: The given key '7' was not present in the dictionary.

WriteLine(myDict.ContainsKey(5)); // True - Fast!
WriteLine(myDict.ContainsValue("seis")); // True - Slow!

// Trying to get value:
string? seven = "";
if (myDict.TryGetValue(7, out seven))
    WriteLine("Value found");
else
    WriteLine("Value not found");
WriteLine($"Seven: '{seven}'");
// Seven: ''

// ITERATING OVER A DICT

foreach (KeyValuePair<int, string> kv in myDict) WriteLine($"Key: {kv.Key} - Value: {kv.Value}");
// Key: 1 - Value: uno
// Key: 2 - Value: dos
// Key: 3 - Value: tres
// Key: 4 - Value: cuatro
// Key: 5 - Value: cinco
// Key: 6 - Value: seis

foreach (int key in myDict.Keys) WriteLine(key);
// 1
// 2
// 3
// 4
// 5
// 6
foreach (string value in myDict.Values) WriteLine(value);
// uno
// dos
// tres
// cuatro
// cinco
// seis

//////////¿SERÁ QUE UN OBJETO ES HASHABLE?//////////
var p1 = new Person("Israel", 31);
var p2 = new Person("Raúl", 74);
var p3 = new Person("Ana", 56);
var p4 = new Person("Chuchita", 29);

var family = new Dictionary<Person, string>();
family[p1] = "yo";
family[p2] = "papá";
family[p3] = "mamá";
family[p4] = "hermana";

WriteLine(family.ContainsKey(p3)); // True
WriteLine(family[p4]); // hermana

class Person
{
    public string Name;
    public int Age;
    public Person(string Name, int Age) { this.Name = Name; this.Age = Age; }

}

