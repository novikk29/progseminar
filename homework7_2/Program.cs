/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
значение этого элемента или же указание, что такого элемента нет. Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

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
int n = getIntFromUser("введите количество строк массива:");
int m = getIntFromUser("введите количество столбцов массива:");
int[,] array = get2DArray(n, m, 0, 10);
print2DArray (array);
Console.WriteLine();
int col = getIntFromUser("введите позицию строки искомого элемента:");
int row = getIntFromUser("введите позицию столбца искомого элемента:");
if (col > n || row > m)
{
    Console.WriteLine("такого элемента в массиве нет");
}
else
{
    object result = array.GetValue(col - 1, row - 1);
    Console.WriteLine($"значение элемента на заданной позиции равно {result}");
}
