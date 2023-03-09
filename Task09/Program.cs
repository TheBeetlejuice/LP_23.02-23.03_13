// Напишите программу, которая выводит 
// случайное число из отрезка [10, 99] и 
// показывает наибольшую цифру числа.

// 78 -> 8  78/10 = 7.8 числа целые, остаток обрасывается (int) 78%10  остаток от деления 
// 12-> 2 
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");
int firstDigit = number / 10;
int secondDigit = number % 10;

// if (firstDigit > secondDigit)
//     Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
// else
//     Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");

int result = firstDigit > secondDigit ? firstDigit : secondDigit;
Console.WriteLine($"Наибольшая цифра числа -> {result}");

// Console.Write($"Наибольшая цифра числа -> ");
// Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit);
