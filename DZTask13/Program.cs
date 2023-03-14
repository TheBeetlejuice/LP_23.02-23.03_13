// Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введи число: ");
long number = Convert.ToInt64(Console.ReadLine());

if (number > 99)
{
    while (number >= 999)
    {
        number = number / 10;
    }
    long thirdDigit = number % 10;
    Console.WriteLine($"Третья цифра -> {thirdDigit}");
}
else
{
    Console.WriteLine($"Третьего числа нет. ");
}

// int Prompt(string message);
// {
//     Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// int number = Prompt("Ввидите число: ");
// if (ValidateNumber(number)) ;

// int GetThirdRank(int number);
// {
//     while (number > 999)
//     {
//         number /= 10;
//     }
//     return number % 10;
// }

// bool ValidateNumber(int number)
// {
//     if (number < 100)
//     {
//         Console.WriteLine("Третьей цифры нет.");
//         return false;
//     }
//     return true;
// }

// int number = Prompt("Введите число: ");
// if (ValidateNumber(number))
// {
//     Console.WriteLine(GetThirdRank(number));
// }