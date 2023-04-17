// Задайте двумерный массив. Напишите программу
// котрая поменяет первую и последнюю строку массива.

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 3} ");
        }
        Console.WriteLine();
    }
}

void RowRemakePosition(int[,] arr)
{
    int lastRowIndex = arr.GetLength(0);
    int firstRowIndex = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int temp = arr[firstRowIndex, j];
        arr[firstRowIndex, j] = arr[lastRowIndex - 1, j];
        arr[lastRowIndex - 1, j] = temp;
    }
}

int[,] matrix = CreateMatrixRndInt(4, 4, 0, 11);
PrintMatrix(matrix);
RowRemakePosition(matrix);
System.Console.WriteLine();
PrintMatrix(matrix);
