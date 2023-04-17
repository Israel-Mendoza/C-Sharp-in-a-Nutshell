// The params modifier, if applied to the last parameter of a method, allows the
// method to accept any number of arguments of a particular type.

/*
Think of this as Python's *args:

def adding_ints(*args):
    final_addition = 0
    for num in args:
        final_addition += num
*/

int total = addingInts(1, 2, 3, 4, 5);
Console.WriteLine(total);
// 15


int addingInts (params int[] someInts) {
    int finalAddition = 0;
    for (int i = 0; i < someInts.Length; i++) {
        finalAddition += someInts[i];
    }
    return finalAddition;
}