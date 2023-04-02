// Задайте массив заполненный случайными 
// положительными трёхзначными числами. 
// Напишите программу, которая покажет 
// количество чётных чисел в массиве.

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
int eventNumbersCount = 0;
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    eventNumbersCount++;
}

Console.WriteLine($"Количество чётных чисел в массиве: {eventNumbersCount} ");

void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}

void PrintArray(int[] array)
{
    Console.Write("Элементы массива: [ ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("]");
}