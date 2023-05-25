using static System.Console;

/*
     Using the same seed guarantees the same series of numbers 
     (if run under the same CLR version), which is sometimes 
     useful when you want reproducibility.
*/
var r1 = new Random(1);
var r2 = new Random(1);
WriteLine(r1.Next(100) + ", " + r1.Next(100));      // 24, 11
WriteLine(r2.Next(100) + ", " + r2.Next(100));      // 24, 11

/*
    If you don’t want reproducibility, you can construct Random with no seed; 
    in that case, it uses the current system time to make one up.
*/

var r3 = new Random();
var r4 = new Random();
WriteLine(r3.Next(100) + ", " + r3.Next(100));      // 34, 42
WriteLine(r3.Next(100) + ", " + r3.Next(100));      // 36, 74