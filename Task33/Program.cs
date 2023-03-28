// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.

//  4; массив [6, 7, 19, 345, 3] -> нет 
//  3; массив [6, 7, 19, 345, 3] -> да

// Console.WriteLine("Введите число: ");
// int Digit = Convert.ToInt32(Console.ReadLine());

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
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

bool SearchDigit(int[] arr, int dig)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == dig) return true;
    }
    return false;
}

int[] array = CreateArrayRndInt(10, 0, 10);
PrintArray(array);
Console.Write("Введите число для поиска в массиве: ");
int digit = Convert.ToInt32(Console.ReadLine());
string output = SearchDigit(array, digit) ? "Число присутствует в массиве." 
                                            : "Число отсутствует в массиве.";
Console.WriteLine(output);
