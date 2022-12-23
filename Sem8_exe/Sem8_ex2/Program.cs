/*
Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, 
сколько раз встречается элемент входных данных.

1, 2, 3 4, 6, 1 2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза
*/


try
{
    int m = ReadInt("Введите кол-во столбцов:");
    int n = ReadInt("Введите кол-во строк:");
    int[,] array = Create2DArray(m, n);
    Print2DArray(array);
    List<(int number, int frequence)> dictionary = FindFrequence(array);
    Console.WriteLine(string.Join("\n", dictionary));
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


List<(int number, int frequence)> FindFrequence(int[,] array)
{
    List<(int number, int count)> dictionary = new List<(int, int)>();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int index = FindIndex(dictionary, array[i, j]);
            if (index != -1)
            {
                dictionary[index] = (array[i, j], dictionary[index].count + 1);
            }
            else
            {
                dictionary.Add((array[i, j], 1));
            }

        }
    }
    return dictionary;

}

int FindIndex(List<(int, int)> list, int number)
{
    for (int i = 0; i < list.Count; i++)
    {
        if (list[i].Item1 == number)
        {
            return i;
        }
    }
    return -1;
}

/*
void PrintAnswer(int[] result)
{
    Console.WriteLine("Частотный словарь:");
    for (var i = 0; i < result.Length; i++)
    {
        Console.Write(result[i] + ";" + " ");
    }
}
*/