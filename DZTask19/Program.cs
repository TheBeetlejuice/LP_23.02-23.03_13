// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number < 100000)
{
    int pal = 0, num = number;
    while (number != 0)
    {
        pal = pal * 10 + number % 10;
        number /= 10;
    }
    Console.WriteLine(num == pal ? "Палиндром" : "Не палиндром");
}
else Console.WriteLine ("Введите пятизначное число! ");

// string rev = string.Concat(value.Reverse());
// Console.WriteLine(value == rev ?
//                     ($"{value}, является палиндромом.") :
//                     ($"{value}, не является палиндромом."));

// void Polindrom(string num)
// {
//     if (num[0] == num[4] && num[1] == num[3])
//     {
//         Console.WriteLine($"Число {num} является палиндромом.");
//     }
//     else Console.WriteLine($"Число {num} не является палиндромом.");
// }

// if (number.Length == 5)
// {
//     Polindrom(number);
// }
// else Console.WriteLine($"Число не пятизначное.");