// Напишите программу, которая 
// выводит случайное трёхзначное число и 
// удаляет вторую цифру этого числа.

// 456 -> 46 
// 782 -> 72 
// 918 -> 98

// int number = new Random().Next(100, 1000);
// Console.WriteLine($"Cлучайное трёхзначное число -> {number}");

int DelDigit(int number)
{
    int firstDigit = number / 100;
    int thirDigit = number % 10;
    int result = firstDigit * 10 + thirDigit;
    return result;
}

int number = new Random().Next(100, 1000);
Console.WriteLine($"Cлучайное трёхзначное число -> {number}");
int newNumber = DelDigit(number);
Console.WriteLine($"Удаление второй цифры из трёхзначного числа -> {newNumber}");

// int firstDigit = number / 100;
// int thirDigit = number % 10;
// int result = firstDigit * 10 + thirDigit;

// Console.WriteLine($"Вывод удаление второй цифры -> {result}");