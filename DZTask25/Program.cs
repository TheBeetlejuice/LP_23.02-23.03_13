// Напишите цикл, который принимает 
// на вход два числа (A и B) и возводит 
// число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

// int expo = Expo(numberA, numberB);
// Console.WriteLine($"Первое число {numberA} в степени второго числа {numberB} = " + expo);

// int Expo(int numA, int numB)
// {
//     int result = 1;
//     for (int i = 1; i <= numB; i++)
//     {
//         result = result * numA;
//     }
//     return result;
// }


int result = 1;
if (numberB < 1)
    Console.Write($"Число B должно быть натуральным.");
else
{
    while (numberB != 0)
    {
        result = result * numberA;
        numberB = numberB - 1;
    }
    Console.WriteLine($"Число A в натурального степени числа B -> " + result);
}
