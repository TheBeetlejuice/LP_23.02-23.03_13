﻿// Напишите программу, которая выводит 
// случайное число из отрезка [10, 99] и 
// показывает наибольшую цифру числа.

// 78 -> 8  78/10 = 7.8 числа целые, остаток обрасывается (int) 78%10  остаток от деления 
// 12-> 2 
// 85 -> 8

int number = new Random().Next(10, 100); // метод Next(указываем исходные данные)
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");

// int firstDigit = number / 10;
// int secondDigit = number % 10;

// if (firstDigit > secondDigit)
//     Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
// else
//     Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");

// int result = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра числа -> {MaxDigit}");

// Console.Write($"Наибольшая цифра числа -> ");
// Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit);

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра из отрезка 10 - 99 -> {maxDigit}");

int MaxDigit(int num) // 
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return result;
}