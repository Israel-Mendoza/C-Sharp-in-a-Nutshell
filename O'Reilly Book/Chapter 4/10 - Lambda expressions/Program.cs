// Using the method by passing an int, and a lambda expression 
// that complies with the Func<int,int> type.
ResultPrinter(12, x => x * x * x);
// 1728

// Using closures.

// Using the Multiplier function:
Func<int, int> ByThree = Multiplier(3);
Func<int, int> ByFive = Multiplier(5);

// Using the counter 
Func<int> Counter1 = Counter(1);
Func<int> Counter2 = Counter(11);

// Multipliers closers:
Console.WriteLine(ByThree(5));
// 15
Console.WriteLine(ByFive(5));
// 25

// Using the counters:
Console.WriteLine(Counter1());
// 1
Console.WriteLine(Counter1());
// 2
Console.WriteLine(Counter1());
// 3
Console.WriteLine(Counter1());
// 4
Console.WriteLine(Counter1());
// 5
Console.WriteLine(Counter2());
// 11
Console.WriteLine(Counter2());
// 12
Console.WriteLine(Counter2());
// 13
Console.WriteLine(Counter2());
// 14
Console.WriteLine(Counter2());
// 15

// Method that accepts an int and a delegate of Func<int,int> type:
void ResultPrinter(int a, Func<int, int> aMethod)
{
    int result = aMethod(a);
    Console.WriteLine(result);
}

// A method that returns a method that complies with Func<int,int>
Func<int, int> Multiplier(int a)
{
    int Inner(int b) => a * b;
    return Inner;
}

// A method that returns a method that complies with Func<int>
Func<int> Counter(int initialValue)
{
    int InnerCounter() => initialValue++;
    return InnerCounter;
}