/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Clear();
int GetUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}
double GetDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt(Math.Pow((x1 - x2),2) + Math.Pow((y1 - y2),2) + Math.Pow((z1 - z2),2));
    return result;
}
int x1 = GetUserValue("введите x1");
int y1 = GetUserValue("введите y1");
int z1 = GetUserValue("введите z1");
int x2 = GetUserValue("введите x2");
int y2 = GetUserValue("введите y2");
int z2 = GetUserValue("введите z2");

double distance = GetDistance(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"расстояние между точками в 3D пространстве: {Math.Round(distance,2)}");

