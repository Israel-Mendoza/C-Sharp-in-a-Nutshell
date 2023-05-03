using static System.Console;

/*
    Stack<T> and Stack are last-in, first-out (LIFO) data structures, 
    providing methods to Push (add an item to the top of the stack) 
    and Pop (retrieve and remove an element from the top of the stack).
*/

var s = new Stack<int>();

s.Push(1);
s.Push(2);
s.Push(3);

WriteLine(s.Count); // Total count of existing items in the Stack.
// 3
WriteLine(s.Peek()); // Returns the first item in the Stack without removing it.
WriteLine(s.Pop()); // Returns and removes the last item in the Stack.
WriteLine(s.Pop());
WriteLine(s.Pop());
try
{
    WriteLine(s.Pop());
}
catch (Exception ex)
{
    WriteLine(ex);
}
// System.InvalidOperationException: Stack empty.