// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние 
// между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine($"Введите координаты первой точки. ");
Console.Write("X: ");
int xCoordA = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordA = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zCoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите координаты второй точки. ");
Console.Write("X: ");
int xCoordB = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordB = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zCoordB = Convert.ToInt32(Console.ReadLine());

double distance = Distance(xCoordA, yCoordA, zCoordA, xCoordB, yCoordB, zCoordB);
Console.WriteLine($"Расстояние между точками равно: {Math.Round(distance, 2, MidpointRounding.ToZero)}");

double Distance(int xA, int yA, int zA, int xB, int yB, int zB)
{
    return Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2));
}
