// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void Main()
{
    int numberM = ReadInt("Введите значение М: ");
    int numberN = ReadInt("Введите значение N: ");
    PrintNumbers(numberM, numberN);
}

void PrintNumbers(int current, int N)
{
    if (current <= N)
    {
        System.Console.Write(current + " ");
        PrintNumbers(current + 1, N);
    }
}


int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();



