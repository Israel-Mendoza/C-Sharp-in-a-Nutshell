////////////////////////TESTING THE DELEGATE///////////////////////////

// Defining an array of ints:
int[] values = { 1, 2, 3 };

// Calling Transform to apply the Square method to the passed array:
Transform(values, Square);

// Printing the result of the "values" array:
foreach (int i in values)
    Console.WriteLine($"{i}");

// Calling Transform to apply the Cube method to the passed array:
Transform(values, Cube);

// Printing the result of the "values" array:
foreach (int i in values)
    Console.WriteLine($"{i}");


// Defining a method that will take an array
// and a delegate of type "Tranformer"
void Transform(int[] values, Transformer t)
{
    // Iterating through the passed array and
    // applying the delegate to the int.
    for (int i = 0; i < values.Length; i++)
        values[i] = t(values[i]);
}


///////////////////DEFINING METHODS AND GENERICS//////////////////////////


// Defining a couple of methods that comply with the Transformer delegate:
int Square(int x) => x * x;
int Cube(int x) => x * x * x;

// Defining a delegate. Takes an int and returns an int.
delegate int Transformer(int x);