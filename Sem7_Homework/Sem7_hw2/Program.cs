/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

try
{
    int m = ReadInt("Введите m:");
    int n = ReadInt("Введите n:");
    int number = ReadInt("Введите позицию элемента в массиве:");
    int[,] array = Create2DArray(m, n);
    Print2DArray(array);
    int result = FindNumberInArray(array, number);
    PrintAnswer(result, number);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

void Print2DArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] Create2DArray(int m, int n)
{
    Random random = new Random();
    int[,] array = new int[m, n];

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }

    return array;
}

int ReadInt(string title)
{
    Console.WriteLine(title);

    bool isParsed = int.TryParse(Console.ReadLine(), out int number);

    if (isParsed)
    {
        return number;
    }

    throw new Exception("Введены не корректные символы");
}

int FindNumberInArray(int[,] array, int number)
{
    int result = 0;
    if (number < array.Length)
    {
        if (number < array.GetLength(0))
        {
            result = array[0, number];
        }
        else
        {
            result = array[number % array.GetLength(0), 0];  //проблема с условием
        }
    }
    else result = -1;
    return result;
}
//number - array.GetLength(1)
void PrintAnswer(int result, int number)
{
    if (result != -1) Console.WriteLine($"Элемент под номером {number} есть и он = {result}.");
    else Console.WriteLine($"Элемента под номером {number} в массиве нет!");
}