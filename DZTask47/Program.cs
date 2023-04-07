// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.


double[,] matrix = new double[3, 4];
Random rnd = new Random();

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = rnd.NextDouble() * 10;
        Console.Write("{0,6:F2}", matrix[i, j]);
    }
    Console.WriteLine();
}
