/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Console.Clear();
int getIntFromUser(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.ResetColor();
    int userInt = int.Parse(Console.ReadLine()!);
    return userInt;
}
void printInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write(data);
    Console.ResetColor();
}
int[,] get2DArray(int colLength, int rowLength, int start, int finish)
{
    int[,] array = new int[colLength, rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i, j] = new Random().Next(start, finish + 1);
        }
    }
    return array;
}
void print2DArray(int[,] array)
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

double Sum(int[,] array)
{ 
    double result = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0; 
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = (sum + array[i, j]);
        }
        result = Math.Round (sum / array.GetLength(0), 1);
        Console.Write(result + "; ");
    }
    return result;
}
int n = getIntFromUser("введите количество строк массива:");
int m = getIntFromUser("введите количество столбцов массива:");
int[,] array = get2DArray(n, m, 0, 10);
print2DArray (array);
Console.WriteLine("-----------------------------------");
double result =  Sum(array);
Console.WriteLine();
Console.WriteLine("-----------------------------------"); 

