// Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает 
// вторую цифру этого числа.

// 456 -> 5 
// 782 -> 8 
// 918 -> 1

Console.Write("Введите трёхзначное число: ");
int value = Convert.ToInt32(Console.ReadLine());

if (value > 99 && value <= 999)
{
    int secondDigit = value / 10 % 10;
    Console.WriteLine($"Вторая цифра из трёхзначного числа -> {secondDigit}");
}
else 
{
    if (value < -99 && value >= -999)
    {
        int secondDigit = value / 10 % 10;
        Console.WriteLine($"Вторая цифра из трёхзначного числа -> {secondDigit}");
    }
    else
    {
        Console.WriteLine($"Число не является трёхзначным.");
    }
}