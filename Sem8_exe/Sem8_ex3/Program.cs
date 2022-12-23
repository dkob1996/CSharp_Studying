/*
Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив: 
14 72
59 23
84 24
52 67
Наименьший элемент - 1, на выходе получим следующий массив:
94 2
22 6
34 7
*/

try
{
    int m = ReadInt("Введите кол-во строк и столбцов одним числом:");
    int[,] array = Create2DArray(m);
    Console.WriteLine("Старый массив:");
    Print2DArray(array);
    (int, int) CoordsOfMin = FindCoordsOfMinElement(array);
    Console.WriteLine();
    Console.WriteLine($"Координаты = [{CoordsOfMin.Item1},{CoordsOfMin.Item2}].");
    int[,] mass = CutMassive(array, CoordsOfMin);
    Console.WriteLine();
    Console.WriteLine("Новый массив:");
    Print2DArray(mass);

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

int[,] Create2DArray(int m)
{
    Random random = new Random();
    int[,] array = new int[m, m];

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


(int, int) FindCoordsOfMinElement(int[,] array)
{
    (int, int) minIndex = (0, 0);
    int min = array[0, 0];

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            if (min > array[i, j])
            {
                min = array[i, j];
                minIndex = (i, j);
            }
        }
    }
    return minIndex;
}

int[,] CutMassive(int[,] array, (int, int) CoordsOfMin)
{

    int[,] RefreshMassive = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    for (int i = 0, n = 0; i < array.GetLength(0); i++)
    {
        if (i != CoordsOfMin.Item1)
        {
            for (int j = 0, m = 0; j < array.GetLength(1); j++)
            {
                if (j != CoordsOfMin.Item2)
                {
                    RefreshMassive[n, m] = array[i, j];
                    m++;
                }
            }
            n++;
        }
    }
    return RefreshMassive;

}