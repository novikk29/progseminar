/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке
от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Clear();
int getIntFromUser(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int sumNaturalNumber(int m, int n)
{
    if (m == n)
        return n;
    return n + sumNaturalNumber(m, n - 1);
}

int m = getIntFromUser("введите M");
int n = getIntFromUser("введите N");
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine($"В промежутке от {m} до {n}, сумма натуральных элементов равна {sumNaturalNumber(m, n)}");
Console.WriteLine("--------------------------------------------------------------");

