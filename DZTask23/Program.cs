﻿// Напишите программу, которая принимает 
// на вход число (N) и выдаёт таблицу 
// кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write($"Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());

void TableCube(int val)
{
    int index = 1;
    int result = 0;
    while (index <= val)
    {
        result = index * index * index;
        Console.WriteLine($"{index} = {result}");
        index++;
    }
}
TableCube(value);