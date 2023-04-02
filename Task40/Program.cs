// Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать 
// треугльник с сторонами такой длины.

bool IsExistTriangle(int a, int b, int c)
{
    if(a + b > c && b + c > a && c + a > b) return true;
    else return false;
}

Console.Write("Введите длину сторны  A: ");
int sindA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину сторны  B: ");
int sindB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину сторны  C: ");
int sindC = Convert.ToInt32(Console.ReadLine());
string qutput = IsExistTriangle(sindA, sindB, sindC) ? "Треуольник может существовать с такими сторонами. " :
                                                    "Треугольник не может существовать с такими сторонами. ";
Console.WriteLine(qutput);