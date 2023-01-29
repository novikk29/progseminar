﻿/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

Console.Clear();
int getIntFromUser(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.ResetColor();
    int userInt = int.Parse(Console.ReadLine());
    return userInt;
}

void printInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write(data);
    Console.ResetColor();
}

double[,] get2DDoubleArray(int colLength, int rowLength, int start, int finish)
{
    double[,] array = new double[colLength, rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i, j] = new Random().Next(start, finish + 1) + Math.Round(new Random().NextDouble(), 1);
        }
    }
    return array;
}

void print2DArray(double[,] array)
{
    Console.Write(" \t");
    for (int j = 0; j < array.GetLength(1); j++)
        {
            printInColor(j + "\t");
        }
    Console.WriteLine(" \t");    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor(i + "\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
 int n = getIntFromUser("введите количество строк");
 int m = getIntFromUser("введите количество столбцов");
 Console.WriteLine("----------------------------------------------------------");
 double[,] array = get2DDoubleArray(n, m, -10, 10);
 print2DArray (array);
 Console.WriteLine("----------------------------------------------------------");
