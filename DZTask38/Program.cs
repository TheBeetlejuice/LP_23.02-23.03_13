// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и 
// минимальным элементами массива.

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] rndArray = new double[size];

void CreateArrayRndInt(int size)
{
    Console.WriteLine("Разница между максимальным и минимальным элементов массива: ");
    Console.Write("[ ");
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        rndArray[i] = rnd.NextDouble();
        Console.Write($"{rndArray[i]:F2} ");
    }
    Console.Write("] -> ");
}

double difference(double[] rndArray)
{
    double min = rndArray[0];
    double max = rndArray[0];
    int i = 1;
    
    while (i < rndArray.Length)
    {
        if (max < rndArray[i])
            max = rndArray[i];
        if (min > rndArray[i])
            min = rndArray[i];
        i = i + 1;
    }
    return max - min;
}

CreateArrayRndInt(size);
Console.WriteLine($"{difference(rndArray):F2}");