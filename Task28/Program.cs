// Напишите проограмму, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.

// 4 -> 24
// 5 -> 120

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int workNumbers = WorkNumbers(number); //вызов метода
Console.WriteLine($"Произведение чисел от 1 до {number} = { workNumbers}");

int WorkNumbers(int num)
{
    int work = 1;
    for (int i = 1; i <= num; i++)
    {
        work *= i; //sum = sum + i;
    }
    return work;
}