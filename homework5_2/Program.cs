/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */ 

Console.Clear();
Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
FillArrayRandomNumbers(array);
Console.Write("В массивe ");
PrintArray(array);

int sum = 0;
for (int k = 1; k < array.Length; k+=2)
{
    sum = sum + array[k];
}
Console.WriteLine($" сумма элементов, стоящих на нечётных позициях, равна {sum}");

void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(1,100);
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