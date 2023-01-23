/*
Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет 
количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/ 

Console.Clear();
Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
FillArrayRandomNumbers(array);
Console.Write("В массивe ");
PrintArray(array);
int count = 0;
for (int k = 0; k < array.Length; k++)
{
    if (array[k] % 2 == 0)
    {
        count++;  
    }
}
Console.WriteLine($" количество чётных чисел равно {count}");

void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1)
        {
        Console.Write(array[i] + ", ");
        }
        else
        {
        Console.Write(array[i] + "]");
        }    
    }
}