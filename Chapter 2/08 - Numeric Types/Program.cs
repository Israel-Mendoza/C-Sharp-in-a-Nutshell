/*
We have three types of numbers:
1. Signed ints.
2. Unsigned ints.
3. Decimal values.
*/

// Signed ints
sbyte signedByte1 = sbyte.MinValue;
sbyte signedByte2 = sbyte.MaxValue;
short short1 = short.MinValue;
short short2 = short.MaxValue;
int int1 = int.MinValue;
int int2 = int.MaxValue;
long long1 = long.MinValue;
long long2 = long.MaxValue;
nint nint1 = nint.MinValue; // Native-sized integers (C#9) for pointer arithmetic.
nint nint2 = nint.MaxValue; // Native-sized integers (C#9) for pointer arithmetic.

Console.WriteLine($"Min and max sbyte values: {signedByte1} - {signedByte2}. Type: {signedByte1.GetType()}");
// Min and max sbyte values: -128 - 127. Type: System.SByte
Console.WriteLine($"Min and max short values: {short1} - {short2}. Type: {short1.GetType()}");
// Min and max short values: -32768 - 32767. Type: System.Int16
Console.WriteLine($"Min and max int values: {int1} - {int2}. Type: {int1.GetType()}");
// Min and max int values: -2147483648 - 2147483647. Type: System.Int32
Console.WriteLine($"Min and max long values: {long1} - {long2}. Type: {long1.GetType()}");
// Min and max long values: -9223372036854775808 - 9223372036854775807. Type: System.Int64
Console.WriteLine($"Min and max nint values: {nint1} - {nint2}. Type: {nint1.GetType()}");
// Min and max nint values: -9223372036854775808 - 9223372036854775807. Type: System.IntPtr

// Unsigned ints
byte byte1 = byte.MinValue;
byte byte2 = byte.MaxValue;
ushort ushort1 = ushort.MinValue;
ushort ushort2 = ushort.MaxValue;
uint uint1 = uint.MinValue;
uint uint2 = uint.MaxValue;
ulong ulong1 = ulong.MinValue;
ulong ulong2 = ulong.MaxValue;
nuint nuint1 = nuint.MinValue; // Native-sized integers (C#9) for pointer arithmetic.
nuint nuint2 = nuint.MaxValue; // Native-sized integers (C#9) for pointer arithmetic.

Console.WriteLine($"Min and max byte values: {byte1} - {byte2}. Type: {byte1.GetType()}");
// Min and max byte values: 0 - 255. Type: System.Byte
Console.WriteLine($"Min and max ushort values: {ushort1} - {ushort2}. Type: {ushort1.GetType()}");
// Min and max ushort values: 0 - 65535. Type: System.UInt16
Console.WriteLine($"Min and max uint values: {uint1} - {uint2}. Type: {uint1.GetType()}");
// Min and max uint values: 0 - 4294967295. Type: System.UInt32
Console.WriteLine($"Min and max ulong values: {ulong1} - {ulong2}. Type: {ulong1.GetType()}");
// Min and max ulong values: 0 - 18446744073709551615. Type: System.UInt64
Console.WriteLine($"Min and max ulong values: {nuint1} - {nuint2}. Type: {nuint1.GetType()}");
// Min and max ulong values: 0 - 18446744073709551615. Type: System.UIntPtr

// Decimal values:
float float1 = float.MinValue;
float float2 = float.MaxValue;
double double1 = double.MinValue;
double double2 = double.MaxValue;
decimal decimal1 = decimal.MinValue; // Financial calculations, 
decimal decimal2 = decimal.MaxValue; // for which base-10-accurate arithmetic and high precision are required.

Console.WriteLine($"Min and max float values: {float1} - {float2}. Type {float1.GetType()}");
// Min and max float values: -3.4028235E+38 - 3.4028235E+38. Type System.Single
Console.WriteLine($"Min and max double values: {double1} - {double2}. Type {double1.GetType()}");
// Min and max double values: -1.7976931348623157E+308 - 1.7976931348623157E+308. Type System.Double
Console.WriteLine($"Min and max decimal values: {decimal1} - {decimal2}. Type {decimal1.GetType()}");
// Min and max decimal values: -79228162514264337593543950335 - 79228162514264337593543950335. Type System.Decimal


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Numeric Literals

/*
We can use decimal or hexadecimal notation as literals. 
We can also insert an underscore anywhere for easier reading. 

The interpreter infers the type of the literals based on the following:

1. If the literal has a point or an exponential sysbol (E), it will be a double.
2. An integer will be assumed as an int, uint, long, and ulong (in that order).
*/

Console.WriteLine($"Type of '1.0': {1.0.GetTypeCode()}");
// Type of '1.0': Double
Console.WriteLine($"Type of '1E06': {1E06.GetTypeCode()}");
// Type of '1E06': Double
Console.WriteLine($"Type of '1': {1.GetTypeCode()}");
// Type of '1': Int32
Console.WriteLine($"Type of '2147483650': {2147483650.GetTypeCode()}"); // int.MaxValue + 3
// Type of '2147483650': UInt32
Console.WriteLine($"Type of '4294967299': {4294967299.GetTypeCode()}"); // uint.MaxValue + 4
// Type of '4294967299': Int64


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Numeric Prefixes

/*
    float i = 1.0F; // Necessary!!
    double j = 1.0D; // Redundant
    decimal k = 1.0M; // Necessary!!
    uint l = 1U; // Redundant
    long m = 1L; // Redundant
    ulong n = 1UL; // Reduntand
*/

