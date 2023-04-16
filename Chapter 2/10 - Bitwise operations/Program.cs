// BITWISE OPERATION

/*
~   Complement
&   And
|   Or
^   Xor
<<  Shift to the left
>>  Shift to the right
*/

// COMPLEMENT

sbyte a = ~0; 
Console.WriteLine(a);
// -1

// AND

byte b = 0b0000_0001 & 0b0000_01001; // The result will turn on all bits that are "on" on both numbers.
Console.WriteLine(b);
// 1 (0b000_0001)

byte c =  0b0000_0001 | 0b0000_01000; // The result will be all the '1' bits on.
Console.WriteLine(c);
// 9 (0b0000_01001)

byte d = 0b0000_1000 ^ 0b0000_1001; // The result will turn on all the bits that are different. 
Console.WriteLine(d);
// 1 (0b0000_0001)

byte e = 0b0000_0001 << 3; // Move the 1 bits three places to the left.
Console.WriteLine(e);
// 8 (0b0000_1000)

byte f = 0b0000_1000 >> 3; // Move the 1 bits three places to the right.
Console.WriteLine(f);
// 1 (0b0000_0001)

