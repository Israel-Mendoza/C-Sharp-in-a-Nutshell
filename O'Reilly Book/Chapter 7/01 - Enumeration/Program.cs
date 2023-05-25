// IMPLEMENTING IEnumerable and IEnumerator IN A SIMPLE CLASS

using static System.Console;
using System.Collections;

var myStrColl = new myStringCollection();

// Getting an IEnumerator from the IEnumerable:
var myEnumerator = myStrColl.GetEnumerator();

// Using the IEnumerator
while (myEnumerator.MoveNext())
{
    Write($"{myEnumerator.Current} ");
}
// One Two Three Four Five Six Seven Eight Nine Ten
WriteLine();


// "foreach" calls the GetEnumerator() method to get the object's IEnumerator:
foreach (var item in myStrColl)
{
    Write($"{item} ");
}
// One Two Three Four Five Six Seven Eight Nine Ten
WriteLine();


class myStringCollection : IEnumerable, IEnumerator
{
    string[] stringHolder = new string[10]
    {
        "One",
        "Two",
        "Three",
        "Four",
        "Five",
        "Six",
        "Seven",
        "Eight",
        "Nine",
        "Ten"
    };
    int counter = -1;

    public object Current => stringHolder[counter];

    public bool MoveNext()
    {
        if (counter == 9)
        {
            Reset();
            return false;
        }
        else
            counter++;
        return true;
    }

    public void Reset()
    {
        counter = -1;
    }

    public IEnumerator GetEnumerator()
    {
        return (IEnumerator)this;
    }
}