// Напишите программу, которая 
// 1. принимает на вход координаты точки(x и y), 
// 2. причём x ≠ 0 Y ≠ 0 и 
// 3. выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine($"Введите координаты точки: ");
Console.Write("X: ");
int xCoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoord = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xCoord, yCoord);
string result = quarter > 0 
                ? $"Указаные координаты соответствуют четверти {quarter}"
                : "Введены некорректные координаты ";

Console.WriteLine(result);

int Quarter (int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}
