using static System.Console;

/*
    Queue<T> and Queue are first-in, first-out (FIFO) data structures, 
    providing meth‐ ods to Enqueue (add an item to the tail of the queue) 
    and Dequeue (retrieve and remove the item at the head of the queue). 
    A Peek method is also provided to return the element at the head of 
    the queue without removing it, as well as a Count property (useful in 
    checking that elements are present before dequeuing).
*/

var q = new Queue<int>();

q.Enqueue(1);
q.Enqueue(2);
q.Enqueue(3);

WriteLine(q.Count); // The total amount of items in the queue.
// 3
WriteLine(q.Peek()); // Returns the first item without removing it.
// 1
WriteLine(q.Dequeue());
// 1
WriteLine(q.Dequeue());
// 2
WriteLine(q.Dequeue());
// 3

try
{
    WriteLine(q.Dequeue());
}
catch (Exception ex)
{
    WriteLine(ex);
}
// System.InvalidOperationException: Queue empty.

