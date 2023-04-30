using System.Text;
using static System.Console;

/*
    The StringBuilder class (System.Text namespace) represents a 
    mutable (editable) string. 
    With a StringBuilder, you can Append, Insert, Remove, and Replace 
    substrings without replacing the whole StringBuilder.
*/

var sb = new StringBuilder();

for (var i = 0; i <= 10; i++)
{
    sb.Append($"{i}, ");
}
WriteLine(sb);

sb.Remove(sb.Length - 2, 2);
WriteLine(sb);
// 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10

sb.Length = 16;
WriteLine(sb);
// 0, 1, 2, 3, 4, 5