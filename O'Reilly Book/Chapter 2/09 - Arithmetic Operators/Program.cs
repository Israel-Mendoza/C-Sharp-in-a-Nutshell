// Increment and Decrement Operators
/*
The increment and decrement operators (++, --, respectively) increment and decrement
numeric types by 1. The operator can either follow or precede the variable,
depending on whether you want its value before or after the increment/decrement;
for example:
*/
int x = 0;
int y = 0;
Console.WriteLine (x++);
// Outputs 0; x is now 1
Console.WriteLine (++y); 
// Outputs 1; y is now 1

//////////////////////////////////////////////////////////////////////////////////////

// OVERFLOW

int a = int.MinValue;
Console.WriteLine(a);
// -2147483648
a--;
Console.WriteLine(a);
// 2147483647

// Checked operator to avoid silent overflow:
int b = 1_000_000;
int c = 1_000_000;
int d = checked(b * c);
// Unhandled exception. System.OverflowException: Arithmetic operation resulted in an overflow.
