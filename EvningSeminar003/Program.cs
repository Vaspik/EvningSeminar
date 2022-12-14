/*
int FindQuadrant(double x, double y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

Console.Write("Input the first coordinate x = ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the two coordinate y = ");
double ya = Convert.ToDouble(Console.ReadLine());

int quadNum = FindQuadrant(xa, ya);
Console.WriteLine($"The point A({xa},{ya} is on the {quadNum} qudrant.");
*/

// Напишите программу, которая по заданному номеру четверти,
//  показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void ShouPointCoordinate(int quand)
{
    if(quand == 1)
    {
        Console.Write("x(0... +∞), y(0... +∞)");
    }
    if(quand == 2)
    {
        Console.Write("x(-∞...0), y(0... +∞)");
    }
    if(quand == 3)
    {
        Console.Write("x(-∞...0), y(-∞...0)");
    }
    if(quand == 4)
    {
        Console.Write("x(0... +∞), y(-∞...0)");
    }
    if(quand < 1 || quand > 4)
    {
        Console.WriteLine("Incorrect quarter");
    }
}

Console.Write("Input qaurter: ");
int quart = Convert.ToInt32(Console.ReadLine());
ShouPointCoordinate(quart);
*/


// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 2D пространстве.

// double FindDistance(double xA, double yA, double xB, double yB)
// {
//     double distance = xA - xB
//     if(xa > xb)
//     {

//     }
// }







// Напишите программу, которая принимает на вход число (N)
//  и выдаёт ряд квадратов чисел от 1 до N.

