/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей 
суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.Clear();
int[,] get2DArray(int rowLength, int colLength, int start, int finish)
{
    int[,] array = new int[rowLength, colLength];
    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colLength; j++)
        {
            array[i, j] = new Random().Next(start, finish + 1);
        }
    }
    return array;
}

void printInColor(string data, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(data);
    Console.ResetColor();
}

void printHeadOfArray(int length)
{
    Console.Write("\t");
    for (int i = 0; i < length; i++)
    {
        printInColor(i + "\t", ConsoleColor.DarkGreen);
    }
    Console.WriteLine();
}
void print2DArray(int[,] array)
{
    printHeadOfArray(array.GetLength(1));    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor(i + "\t", ConsoleColor.Cyan);
        for (int j = 0; j < array.GetLength(1); j++)
        {
                Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int minSumRow(int[,] array)
{
    int minSum = 0;
    int row = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minSum += array[0, i];
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j]; 
        }
        if(sum < minSum)
        {
            minSum = sum;
            row = i;
        }
    }
    return row;
}

int[,] array = get2DArray(3, 5, 0, 10);
print2DArray(array);
Console.WriteLine("------------------------------------------");
Console.WriteLine($" индекс строки с наименьшей суммой: {minSumRow(array)}");