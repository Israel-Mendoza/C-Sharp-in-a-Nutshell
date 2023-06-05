using static System.Console;

Write("Enter the first number: ");
int number1 = int.Parse(ReadLine()!);

Write("Enter the second number: ");
int number2 = int.Parse(ReadLine()!);

Write("Enter the operation: ");
string operation = ReadLine()!.ToUpperInvariant();

var calculator = new Calculator();
int result = calculator.Calculate(number1, number2, operation);

DisplayResult(result);

WriteLine("Press ENTER to exit...");
ReadLine();

void DisplayResult(int result) => WriteLine($"The result is {result}");

