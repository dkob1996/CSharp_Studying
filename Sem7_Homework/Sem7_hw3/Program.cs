/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

try
{
    int m = ReadInt("Введите кол-во столбцов:");
    int n = ReadInt("Введите кол-во строк:");
    int[,] array = Create2DArray(m, n);
    Print2DArray(array);
    double[] result = FindAverageInColumns(array);
    PrintAnswer(result);
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

double[] FindAverageInColumns(int[,] array)
{
    double[] mass = new double[array.GetLength(0)];
    double[] result = new double[array.GetLength(0)];

    for (var j = 0; j < array.GetLength(1); j++)
    {
        for (var i = 0; i < array.GetLength(0); i++)
        {
            result[j] = result[j] + array[i, j];
        }
        mass[j] += result[j] / array.GetLength(0);
    }
    return mass;
}

void PrintAnswer(double[] result)
{
    Console.WriteLine("Среднее арифметическое каждого столбца:");
    for (var i = 0; i < result.Length; i++)
    {
        Console.Write(result[i] + ";" + " ");
    }
}
