// Using the generic delegate to wrap methods with different types:
var intDel = new MyDelegate<int>(PrintNum); // Using int
var strDel = new MyDelegate<string>(StringMocker); // Using string

// Invoking the delegates:
int intResult = intDel(5);
string strResult = strDel("Huevos!");

Console.WriteLine(intResult);
// 25
Console.WriteLine(strResult);
// This is your string? 'Huevos!'... Come on, you can do better!


/////////DEFINING A GENERIC DELEGATE AND A COUPLE OF METHODS TO BE WRAPPED BY THE DELEGATE/////////

// Creating two different methods to be wrapped by the delegate.
int PrintNum(int aNumber) => aNumber * aNumber;
string StringMocker(string aWord) => $"This is your string? '{aWord}'... Come on, you can do better!";

// The delegate that takes a given type and returns an object of the same type:
delegate T MyDelegate<T>(T anObject);