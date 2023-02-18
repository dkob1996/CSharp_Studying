/*
Task 59: Set a two-dimensional array of integers. Write a program that will delete the row and column at the intersection of which the smallest element of the array is located.
For example, an array is given: 
14 72
59 23
84 24
52 67
The smallest element is 1, at the output we get the following array:
94 2
22 6
34 7
*/

try
{
    int m = ReadInt("Enter the number of rows and columns in one number:");
    int[,] array = Create2DArray(m);
    Console.WriteLine("Old array:");
    Print2DArray(array);
    (int, int) CoordsOfMin = FindCoordsOfMinElement(array);
    Console.WriteLine();
    Console.WriteLine($"Coordinates = [{CoordsOfMin.Item1},{CoordsOfMin.Item2}].");
    int[,] mass = CutMassive(array, CoordsOfMin);
    Console.WriteLine();
    Console.WriteLine("New array:");
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

    throw new Exception("Incorrect symbols have been entered");
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