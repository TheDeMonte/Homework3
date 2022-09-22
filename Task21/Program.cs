// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
double S (int x, int y, int X, int Y, int z, int Z)
{
    if (x == X && y == Y && z == Z) return 0;
    int numX = x - X;
    int numY = y - Y;
    int numZ = z - Z;
    return Math.Sqrt(numX*numX + numY*numY + numZ * numZ);
}

Console.WriteLine ("Введите координаты первой точки");
Console.Write ("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write ("Y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write ("Z: ");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координаты второй точки");
Console.Write ("X: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write ("Y: ");
int Y = Convert.ToInt32(Console.ReadLine());
Console.Write ("Z: ");
int Z = Convert.ToInt32(Console.ReadLine());
double S1 = S(x, y, X, Y, z, Z);
S1 = Math.Round(S1, 2, MidpointRounding.ToZero);
Console.WriteLine ($"Расстояние между точками равно {S1}");