/*
Задача 23

Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/ 

Console.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
   if (i<n)
   {
    Console.Write(Math.Pow(i,3) + ", ");
   }
   else
   {
    Console.Write(Math.Pow(i,3) + " ");
   }    
}
