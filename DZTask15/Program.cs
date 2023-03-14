// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek(int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("Урааа, выходнооой!");
    }
    else if (dayNumber < 1 || dayNumber > 7)
    {
        Console.WriteLine("Такого дня недели не существует :P ");
    }
    else Console.WriteLine("Сегодя придеться поработать!)");
}

CheckingTheDayOfTheWeek(dayNumber);


