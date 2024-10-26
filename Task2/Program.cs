// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

void Main()
{
    int numberm = ReadInt("Введите значение m: ");
    int numbern = ReadInt("Введите значение n: ");
    int result = A(numberm, numbern);
    Console.WriteLine($"Значение функции Аккермана для ({numberm}, {numbern}) равно: {result}");
}

int A(int m, int n)
{
    if (m == 0)
        return (n + 1);
    else if (n == 0)
        return A(m - 1, 1);
    else
        return A((m - 1), A(m, n - 1));
}


int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();
