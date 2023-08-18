// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координаты точки");
Console.Write("X1: ");
int x1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
int z1Coordinate = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите координаты точки");
Console.Write("X2: ");
int x2Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
int z2Coordinate = Convert.ToInt32(Console.ReadLine());

double distance = DistanceXY(x1Coordinate, x2Coordinate, y1Coordinate, y2Coordinate, z1Coordinate, z2Coordinate);
double distanceRound = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояния между точками: {distanceRound}");

double DistanceXY(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double result = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
    return result;
}