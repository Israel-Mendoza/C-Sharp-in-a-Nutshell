/* 
Implicit conversion happens when:

1. When the compiler can guarantee the conversion will succeed.
2. No information is lost during the conversion.
*/

int x = 12345;
Console.WriteLine(x.GetType());
// System.Int32

long y = x;
Console.WriteLine(y.GetType());
// System.Int64

/* 
Explicit conversion happens when:

1. When the compiler cannot guarantee the conversion will succeed.
2. Information may be lost during the conversion.
*/

short z = (short)y;
Console.WriteLine(z.GetType());
// System.Int16