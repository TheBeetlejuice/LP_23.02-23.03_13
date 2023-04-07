// Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: 
// Amn = m+n. Выведите полученный массив на экран.

// m = 3, n = 4. 012 3 123 4 234 5

int[,] CreateMatrixByIndex(int rows, int colums)
{
    int[,] matrix = new int[rows, colums];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j], 4} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrixByIndex(3, 4);
PrintMatrix(matrix);