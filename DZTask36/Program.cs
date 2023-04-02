// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = CreateArrayRndInt(4, -100, 100);
PrintArray(array);

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.WriteLine("Сумма элементов массива, стоящих на нечётных позициях:");
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("] -> ");
}

int sumOddNmberCount = 0;

for (int i = 1; i < array.Length; i += 2)
{
    sumOddNmberCount += array[i];
}
Console.WriteLine($"{sumOddNmberCount}");