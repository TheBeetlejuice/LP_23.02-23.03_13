// Напишите программу, которая принимает 
// на вход два числа и проверяет, является ли 
// одно число квадратом другого.
  
// 5, 25 -> да 
// -4, 16 -> да 
// 25, 5 -> да

Console.Write("Введите первое чсло: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе чсло: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SqrtNumbers(firstNumber, secondNumber) ? "Да" : "Нет");

bool SqrtNumbers(int firstNum, int secondNum)
{
    return firstNum * firstNum == secondNum || secondNum * secondNum == firstNum;
}
