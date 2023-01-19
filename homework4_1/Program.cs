/* 
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/ 

Console.Clear();
int Res(int numA, int numB)
{
    int result = 1;
    for (int i = 1; i <= numB; i++)
    {
        result = result * numA;
    }
    return result;
}
Console.WriteLine("введите A: ");
int numA = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите B: ");
int numB = int.Parse(Console.ReadLine()!);

int res = Res(numA, numB);
Console.WriteLine($"число {numA} в степени {numB} равно {res}");

