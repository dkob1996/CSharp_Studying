/*
Task 47. Define a two-dimensional array of size m ×n filled with random real numbers.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/


try
{
    int m = ReadInt("Enter m");
    int n = ReadInt("Enter n");
    double[,] array = Create2DArray(m,n);
    Print2DArray(array);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

void Print2DArray(double[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

double[,] Create2DArray(int m, int n)
{
    double[,] array = new double[m,n];

    Random rand = new Random();

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
           array[i,j] = Math.Round(-10 + rand.NextDouble() * (10), 2);
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

