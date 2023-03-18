// Напишите программу, которая принимает 
// на вход координаты двух точек и находит
// расстояние между нми в 2D прострастве.

// A(3,6); B(2,1) -> 5,09
// A(7,-5); B(1,-1) -> 7,21

// double res = Math.Sqrt(5);
// double resRound = Math.Round(res, 2, MidpointRounding.ToZero); //стртегия округления

// Console.WriteLine(resRound);

Console.WriteLine($"Введите координаты первой точки: ");
Console.Write("X: ");
int xCoordA = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите координаты второй точки: ");
Console.Write("X: ");
int xCoordB = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordB = Convert.ToInt32(Console.ReadLine());

double distance = Distance(xCoordA, yCoordA, xCoordB, yCoordB);
Console.WriteLine($"Расстояние между точками равно: {Math.Round(distance, 2, MidpointRounding.ToZero)}");

double Distance(int xA, int yA, int xB, int yB)
{
    return Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2)); // Sqrt - извлечение корня, Pow - возведение в квадрат
}