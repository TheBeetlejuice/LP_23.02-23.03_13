// напишите программу, которая принимает
// на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

// 5 -> 1,4,9,16,25.
// 2 -> 1,4.

Console.Write($"Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());

void TableSquare(int val)
{
    int index = 1;
    int result = 0;
    while (index <= val)
    {
        result = index * index;
        Console.WriteLine($"{index} = {result}");
        index++;
    }
}
TableSquare(value);
