/////////////////USING THE DELEGATES/////////////////

// No need to pre-defined the delegates. They'll be instantiated even without previous definition. 

// Using a Func generic delegate to wrap the Cube and the Capitalize methods:
var f1 = new Func<int, int>(Cube);
var f2 = new Func<string, string>(Capitalize);
// Using an Action generic delegate to wrap the IsEvenPrinter and PrintInCapital methods:
var a1 = new Action<int>(IsEvenPrinter);
var a2 = new Action<string>(PrintInCapital);
// Using a Predicate generic delegate to wrap the IsEven method:
var p = new Predicate<int>(IsEven);

// Printing the return value of f1 and f2 (they return values, remember?):
Console.WriteLine(f1(3));
// 27
Console.WriteLine(f2("Hello!"));
// HELLO!

// Running the Action delegates (no return, remember?):
a1(3);
// 3 is an odd number.
a2("¡Hola!");
// ¡HOLA!

// Using the Predicate delegate (returns a bool, remember?)
if (p(3))
    Console.WriteLine("3 is even number.");
else
    Console.WriteLine("3 is an odd number.");
// 3 is an odd number.


//////////////////////////////DEFINING METHOD//////////////////////////////

int Cube(int a) => a * a * a;
string Capitalize(string a) => a.ToUpper();
void IsEvenPrinter(int a)
{
    if (a % 2 == 0)
        Console.WriteLine($"{a} is an even number.");
    else
        Console.WriteLine($"{a} is an odd number.");
}
void PrintInCapital(string a) => Console.WriteLine(a.ToUpper());
bool IsEven(int a) => a % 2 == 0;



//////////////////////////////DEFINING DELEGATES//////////////////////////////
/*
    Func defines a delegate that has a return value
    and accepts any number of arguments (from 0 to 16).
*/
delegate TResult Func<out TResult>(); // Returns an object of a given type. No arguments.
delegate TResult Func<in T, out TResult>(T arg); // Returns an object of a given type. 1 argument.
delegate TResult Func<in T1, in T2, out TResult>(T1 arg1, T2 arg2); // Returns an object of a given type. 2 arguments.

/*
    Action defines a delegate that has no return value
    and accepts any number of arguments (from 0 to 16).
*/
delegate void Action(); // No return. No arguments.
delegate void Action<in T>(T arg); // No return. 1 argument.
delegate void Action<in T1, in T2>(T1 arg1, T2 arg2); // No return. 2 arguments.

/*
    Predicate defines a delegate that returns a bool
    and accepts any number of arguments (from 0 to 16).
    Exactly the same as Func, but it alwats returns a bool.
*/
delegate bool Predicate<in T>(T arg); // 1 argument.
delegate bool Predicate<in T1, in T2>(T1 arg1, T2 arg2); // 2 arguments.