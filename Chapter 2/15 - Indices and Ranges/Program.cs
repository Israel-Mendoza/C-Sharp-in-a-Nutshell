// INDICES
/*
Indices let you refer to elements relative to the end of an array, with the ^ operator.
^1 refers to the last element, ^2 refers to the second-to-last element, and so on
*/

Index first = 0;
Index last = ^1;

char[] vowels = new char[5] {'a', 'e', 'i', 'o', 'u'};

Console.WriteLine(vowels[first]);
// a
Console.WriteLine(vowels[last]);
// u

// RANGES

/*
Ranges let you 'slice' an array by using the .. operator.
*/

char[] firtsTwo = vowels[..2];
char[] lastThree = vowels [2..];
char[] threeMiddleOnes = vowels[1..4];

Console.WriteLine(firtsTwo);
// ae
Console.WriteLine(lastThree);
// iou
Console.WriteLine(threeMiddleOnes);
// eio

Range lastTwo = ^2..;
Range firstThree = 0..3;

Console.WriteLine(vowels[lastTwo]);
Console.WriteLine(vowels[firstThree]);
// ou
// aei
