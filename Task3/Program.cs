// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.


void Main()
{
    int arraySize = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(arraySize);
    System.Console.WriteLine("Массив прямой: ");
    PrintArray(array, array.Length - 1);
    System.Console.WriteLine();
    System.Console.WriteLine("Массив наоборот: ");
    PrintArrayReverse(array, array.Length - 1);
}

void PrintArray(int[] arr, int i)
{
    if (i >= 0)
    {
        PrintArray(arr, i - 1);
        Console.Write(arr[i] + " ");
        
    }
}


void PrintArrayReverse(int[] arrayForPrint, int index)
{
    if (index >= 0)
    {
        Console.Write(arrayForPrint[index] + " ");
        PrintArrayReverse(arrayForPrint, index - 1);
    }
}


int[] GenerateArray(int size)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
        tempArray[i] = rand.Next(10, 99);

    return tempArray;
}


int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();

