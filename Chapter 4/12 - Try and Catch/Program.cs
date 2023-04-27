int Divide(int x) => 10 / x;

int result;
try
{
    result = Divide(0);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex);
}
finally
{
    result = 0;
}
// System.DivideByZeroException: Attempted to divide by zero.
//    at Program.<<Main>$>g__Divide|0_0(Int32 x) in

Console.WriteLine($"Result: {result}");
// Result: 0