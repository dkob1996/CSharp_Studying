/*
Task 55: Define a two-dimensional array. Write a program
that replaces rows with columns. If this is not possible, the program should output a message to the user.
*/

try
{
    int m = ReadInt("Enter the number of columns:");
    int n = ReadInt("Enter the number of lines:");
    int[,] array = Create2DArray(m, n);
    Print2DArray(array);
    int[,] result = FlipMatix(array);
    Console.WriteLine("Inverted matrix:");
    Print2DArray(result);
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

    throw new Exception("Incorrect symbols have been entered");
}

int[,] FlipMatix(int[,] array)
{
    int[,] mass = new int[array.GetLength(0), array.GetLength(1)];

    if (array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine("The matrix is not square!");
    }
    else
    {
        for (var i = 0; i < array.GetLength(0); i++)
        {
            for (var j = 0; j < array.GetLength(1); j++)
            {
                mass[i,j]=array[j,i];
            }
        }
    }
    return mass;

}
