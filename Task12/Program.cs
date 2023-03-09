﻿// Напишите программу, которая будет принимать
// на вход два числа и выводить, является ли первое число
// кратным второму. сли число 1 не кратно числу 2,
// то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите первое чсло: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе чсло: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int remainsdigits = RemainsDigits(firstNumber, secondNumber);
Console.WriteLine(remainsdigits == 0 ? "Кратно" : $"Не кратно, остаток -> {remainsdigits}");

int RemainsDigits(int firstNumber, int secondNumber)
{
    return firstNumber % secondNumber;
}