/* Задача 38: Задайте массив вещественных чисел. Найдите разницу 
между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */ 

Console.Clear();
Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());
double[] array = new double[size];
FillArrayRandomNumbers(array);
Console.Write("В массиве ");
PrintArray(array);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int k = 0; k < array.Length; k++)
{
    if (array[k] > max)
        {
            max = array[k];
        }
    if (array[k] < min)
        {
            min = array[k];
        }
}

Console.WriteLine($" разница между максимальным и минимальным значением равна {max - min}");

void FillArrayRandomNumbers(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
           array[i] = Convert.ToDouble(new Random().Next(-1000, 1000) / new Random().Next(-100, 100) + 0.0);
        }
}
void PrintArray(double[] array)
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