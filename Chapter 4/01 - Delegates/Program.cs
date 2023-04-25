// Create an instance of delegate and pass sum method as a parameter 
myDelegate d = new myDelegate(sum);

// Multicast delegate calls difference() method 
d += difference;

// Pass values to two methods: sum() and difference()
d(6, 5);

/////////////////////METHODS AND DELEGATE DEFENITIONS////////////////////////

// Method that prints sum of two int numbers 
void sum(int x, int y) => Console.WriteLine("Sum is: " + (x + y));

// Method that prints difference of two int numbers 
void difference(int x, int y) => Console.WriteLine("Difference is: " + (x - y));

// Define a delegate of int type 
delegate void myDelegate(int num1, int num2);
// Sum is: 11
// Difference is: 1