// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();

// string rev = string.Concat(value.Reverse());
// Console.WriteLine(value == rev ?
//                     ($"{value}, является палиндромом.") :
//                     ($"{value}, не является палиндромом."));

void Polindrom(string num)
{
    if (num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine($"Число {num} является палиндромом.");
    }
    else Console.WriteLine($"Число {num} не является палиндромом.");
}

if (number.Length == 5)
{
    Polindrom(number);
}
else Console.WriteLine($"Число не пятизначное.");