/*
Task 53: Define a two-dimensional array. Write a program that will swap the first and last row of the array.
*/


try
{
    int m = ReadInt("Enter m");
    int n = ReadInt("Enter n");
    int[,] array = Create2DArray(m, n);
    Print2DArray(array);
    Console.WriteLine();
    Reparir2DArray(array);
    Print2DArray(array);
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
    int[,] array = new int[m, n];

    Random random = new Random();

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

    throw new Exception("Incorrect symbols have been entered");
}

void Reparir2DArray(int[,] array)
{
    int tmp = 0;
    for (var j = 0; j < array.GetLength(1); j++)
    {
        tmp = array[0, j];
        array[0, j] = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = tmp;
    }

}
