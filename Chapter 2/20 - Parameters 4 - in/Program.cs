// THE in MODIFIER

/*
It won't modify the variable. It helps us working with large variables
so we don't have to copy them every time and causing memory overhead.
*/

long aLargeNumber = long.MaxValue;
Printer(in aLargeNumber);
// Não vou fazer nada com este 9223372036854775807

void Printer (in long largeNum) {
    Console.WriteLine($"Não vou fazer nada com este {largeNum}");
}