/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число
 и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/ 

Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int n = num;
int rev = 0;

while (n > 0)
{
    int r = n % 10;
    rev = rev * 10 + r;
    n = n / 10;
}

if (num == rev)
{
    Console.WriteLine("палиндром");
}
else
{
    Console.WriteLine("не палиндром");
}

