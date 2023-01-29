/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько 
чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */ 

Console.Clear();
int getIntFromUser(string message)
{
    Console.WriteLine(message);
    int userInt = int.Parse(Console.ReadLine());
    return userInt;
}
int countPositiveNumber(int m)
{
    int k = 0;
    int count = 0;

    while(k < m)
    {
        Console.Write("введите число: ");
        int b = int.Parse(Console.ReadLine());
        if(b > 0)
        {
            count++;
            k++;
        }
        else
        {
            k++;
        }
    }
    return count;   
}
 int number = getIntFromUser("введите число m");
int count = countPositiveNumber(number);
Console.WriteLine($"из введённых {number} чисел, положительных {count}");
