// Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write($"Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int len = Length(numberN);
Console.WriteLine($"Сумма цифр в числе {numberN} = {Sum(numberN, len)}");

int Length(int numberN)
{
    int index = 0;
    while (numberN != 0)
    {
        numberN /= 10;
        index++;
    }
    return index;
}

int Sum(int numberN, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += numberN % 10;
        numberN /= 10;
    }
    return sum;
}

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int SumN(int n)
// {
//     int count = Convert.ToString(n).Length;
//     int advance = 0;
//     int result = 0;

//     for (int i = 0; i < count; i++)
//     {
//         advance = n - n % 10;
//         result = result + (n - advance);
//         n = n / 10;
//     }
//     return result;
// }

// int sumN = SumN(n);
// Console.WriteLine("Сумма цифр в числе: " + sumN);
