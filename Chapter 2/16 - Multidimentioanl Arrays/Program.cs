int[,] matrix = new int [5,5];

int counter = 0;

for (int i = 0; i < matrix.GetLength(0); i++) {
    for (int j = 0; j < matrix.GetLength(1); j++) {
        matrix[i,j] = counter;
        counter++;
    }
}

for (int i = 0; i < matrix.GetLength(0); i++) {
    for (int j = 0; j < matrix.GetLength(1); j++) {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
// 0 1 2 3 4 
// 5 6 7 8 9 
// 10 11 12 13 14 
// 15 16 17 18 19 
// 20 21 22 23 24 

int[,] newMatrix = new int[,] {
    {1, 2, 3, 4, 5},
    {6, 7, 8, 9, 10}, 
    {11, 12, 13, 14, 15},
    {16, 17, 18, 19, 20},
    {21, 22, 23, 24, 25}
};

for (int i = 0; i < newMatrix.GetLength(0); i++) {
    for (int j = 0; j < newMatrix.GetLength(1); j++) {
        Console.Write($"{newMatrix[i, j]} ");
    }
    Console.WriteLine();
}
// 1 2 3 4 5 
// 6 7 8 9 10 
// 11 12 13 14 15 
// 16 17 18 19 20 
// 21 22 23 24 25 