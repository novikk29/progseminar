/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/


Console.Clear();
int getIntFromUser(string message)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

string getStrRange(int start, int finish)
{
    if(start == finish)
    {
        return start + "";
    }
    return getStrRange(start + 1, finish) + "," + start;
}
int userNumberFinish = getIntFromUser("введите N");
string range = getStrRange(1, userNumberFinish);
Console.WriteLine(range);
