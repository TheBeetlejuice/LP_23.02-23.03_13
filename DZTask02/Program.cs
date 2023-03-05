// Напишите программу, которая на вход 
// принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10 
// a = -9; b = -3 -> max = -3

Console.WriteLine("Максимальное и минимальное число из двух.");

Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите ворое число");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA > numberB)
{
    int max = numberA;
    Console.WriteLine($"Максимальным числом является -> {numberA}");
    int min = numberB;
    Console.WriteLine($"Минимальным числом является -> {numberB}");
}
else
{
    int max = numberB;
    Console.WriteLine($"Максимальным числом является -> {numberB}");
    int min = numberA;
    Console.WriteLine($"Минимальным числом является -> {numberA}");
}