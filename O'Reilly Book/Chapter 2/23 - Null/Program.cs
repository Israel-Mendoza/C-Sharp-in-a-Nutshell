// NULL-COALESCING OPERATOR

/*
The ?? operator is the null-coalescing operator. 
It says, “If the operand to the left is non-null, give it to me; 
otherwise, give me another value.”
*/

string s1 = null;
// s2 is s1 if the latter is not null. Otherwise, it'll be "nothing".
string s2 = s1 ?? "nothing"; 
string s3 = s2 ?? "nada";

Console.WriteLine("Let's see what we get!");
// Let's see what we get!
Console.WriteLine(s1);
//
Console.WriteLine(s2);
// nothing
Console.WriteLine(s3);
// nothing

///////////////////////////////////////////////////////////////////////////

// NULL-COALESCING ASSIGNMENT OPERATOR

/*
The ??= operator (introduced in C# 8) is the null-coalescing assignment operator. It
says, “If the operand to the left is null, assign the right operand to the left operand.”
*/

string myName = null;
// If myName is equal to null, then assign it the value "Israel".
myName ??= "Israel";
Console.WriteLine(myName);
// Israel

// NULL-CONDITIONAL OPERATOR

/*
The ?. operator is the null-conditional or “Elvis” operator.
It allows you to call methods and access members just like the standard dot operator
except that if the operand on the left is null, the expression evaluates to null instead
of throwing a NullReferenceException.
*/

string myLastName = null;
int[] myNums = null;
Console.WriteLine(myLastName?.ToUpper());
//
Console.WriteLine(myNums?[5]);
//
