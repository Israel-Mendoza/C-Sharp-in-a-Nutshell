using static System.Console;

var s1 = @"\\server\fileshare\project\Program.cs";

// Using the string constructor (accepts only chars)
var s2 = new string('*', 20);
char[] chars = "Israel".ToCharArray();
var s3 = new string(chars);

WriteLine($"Type: '{s1.GetType()}' - Value: '{s1}'");
// Type: 'System.String' - Value: '\\server\fileshare\project\Program.cs'
WriteLine($"Type: '{s2.GetType()}' - Value: '{s2}'");
// Type: 'System.String' - Value: '********************'
WriteLine($"Type: '{s3.GetType()}' - Value: '{s3}'");
// Type: 'System.String' - Value: 'Israel'

////////////////////NULL AND EMPTY STRING////////////////////

string empty = "";
Console.WriteLine(empty == "");// True
Console.WriteLine(empty == string.Empty); // True
Console.WriteLine(empty.Length == 0); // True

string? nullString = null;
Console.WriteLine(nullString == null); // True
Console.WriteLine(nullString == ""); // False
// Console.WriteLine(nullString.Length == 0); // NullReferenceException (Runtime)
WriteLine(string.IsNullOrEmpty(empty)); // True
WriteLine(string.IsNullOrEmpty(nullString)); // True

////////////////////ACCESSING CHARS IN STRINGS////////////////////

string str = "Israel";
char r = str[2];
WriteLine(r); // r

////////////////////SEARCHING WITHIN STRINGS////////////////////

var aString = "Que porra é essa, batata?";
WriteLine(aString.StartsWith("Que")); // True
WriteLine(aString.Contains("porra")); // True
WriteLine(aString.EndsWith("batata?")); // True
WriteLine(aString.IndexOf("é")); // 10
WriteLine(aString.LastIndexOf("é")); // 10

////////////////////MANIPULATING STRINGS////////////////////

// Getting substrings
var firstFiveChars = aString.Substring(0, 5); // Start and length.
var lastFiveChars = aString.Substring(aString.Length - 5); // Start till the end.

WriteLine(firstFiveChars); // Que p
WriteLine(lastFiveChars); // tata?

// Inserting and removing characters
var fixedString = "helloworld".Insert(5, ", "); // At index, and what?
WriteLine(fixedString); // hello, world
var unfixedString = fixedString.Remove(5, 2); // At index, and how many?
WriteLine(unfixedString); // helloworld

// Trimming
var spaceAtLeft = "     hello";
var spaceAtRight = "hello     ";
var spaceAllAround = "     hello     ";
WriteLine(spaceAtLeft.TrimStart()); // "hello"
WriteLine(spaceAtRight.TrimEnd()); // "hello
WriteLine(spaceAllAround.Trim()); // "hello

// Splitting strings

var a1 = "This is what you are really addicted to";
string[] a2 = a1.Split(' ');
foreach (string word in a2)
{
    Write($"{word} ");
}
// This is what you are really addicted to 
WriteLine();
var a3 = string.Concat(a2);
WriteLine(a3); // Thisiswhatyouarereallyaddictedto