/*
Task 49: Define a two-dimensional array. Find the elements
that have both indexes odd, and replace these elements with their
squares.
For example, initially the array looked like this:
1 4 7 2
5 9 2 3
8 4 2 4
The new array will look like this:
1 4 7 2
5 81 2 9
8 4 2 4
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
    //int[,] mass = Reparir2DArray(array);
    //Print2DArray(mass);
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

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0) array[i, j] = array[i, j] * array[i, j];
        }
    }
}


/*
int[,] Reparir2DArray(int[,] array)
{
    int[,] mass = new int[array.GetLength(0), array.GetLength(1)];

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0) mass[i, j] = array[i, j] * array[i, j];
            else mass[i, j] = array[i, j];
        }
    }

    return mass;
}
*/