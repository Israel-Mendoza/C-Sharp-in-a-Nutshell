using static System.Console;

/*
    LinkedList implements IEnumerable<T> and ICollection<T> (and their nongeneric
    versions), but not IList<T> because access by index is not supported.
*/

var escala = new LinkedList<string?>();

escala.AddFirst("do");                          // do
escala.AddLast("si");                           // do - si
escala.AddAfter(escala.First!, "re");            // do - re - si
escala.AddAfter(escala.First!.Next!, "mi");       // do - re - mi - si
escala.AddBefore(escala.Last!, "la");            // do - re - mi - la - si
escala.AddBefore(escala.Last!.Previous!, "sol");  // do - re - mi - sol - la - si
escala.AddAfter(escala.First.Next!.Next!, "fa"); // do - re - mi - fa - sol - la - si

foreach(var nota in escala) Write($"{nota} ");
// do re mi fa sol la si 
WriteLine();

WriteLine(escala.Count); // 7

string? n = escala.Find("fa")?.Value;

WriteLine(n?.GetType());

var calificaciones = new LinkedList<double>();
calificaciones.AddFirst(8.5);
calificaciones.AddLast(5.8);
calificaciones.AddAfter(calificaciones.First!, 9.5);

foreach(var nota in calificaciones) Write($"{nota} ");
WriteLine();

double primeraCalif = calificaciones.First!.Value;

WriteLine($"Type: {primeraCalif.GetType()} - Value: {primeraCalif}");