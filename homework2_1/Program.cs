/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное
 число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.Clear();
Console.WriteLine("Введите трёхзначное число:");
int number = int.Parse(Console.ReadLine()!);
int ExtractionSecondDigit(int number)
{
    int num2 = number / 10;
    int result = num2 % 10;
    return result;
}
int SecondDigit = ExtractionSecondDigit(number);

Console.WriteLine($"вторая цифра числа {number}: {SecondDigit}"); 