/* 
Задача 15: Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет,
является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/ 

Console.Clear();
Console.WriteLine("Введите цифру: ");
int result = int.Parse(Console.ReadLine()!);
if (result == 6 || result == 7)
{
    Console.WriteLine("выходной день");
}
else if (result > 7 || result < 1)
{
    Console.WriteLine("это не день недели");
}
else Console.WriteLine("будний день");
