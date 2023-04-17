// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое 
// элементов в каждом столбце.

Console.Write("введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[rows, colums];
FillArrayRandomNumbers(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine(" ");
    }
}

for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / rows;
    Console.Write($"{avarage:F2}" + "; ");
}
Console.WriteLine();
PrintArray(numbers);
