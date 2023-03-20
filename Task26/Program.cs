// Напишите задачу, которая принимает
// на вход число и выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int countDigit = CountDigit(num);
Console.WriteLine($"В числе {num} содержится {countDigit} цифр(а/ы)");

int CountDigit(int number)
{
    int digit = 0;
    do // сначало выполняем действие, потом проверяем
    {
        number /= 10; // number = number / 10
        digit++;
    } while (number != 0);
    return digit;
}