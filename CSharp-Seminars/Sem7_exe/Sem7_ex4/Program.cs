/*
Task 51: Define a two-dimensional array. Find the sum
of the elements located on the main diagonal (with indexes
(0,0); (1;1), etc.
For example, an array is given:
1 47 2
5 92 3
8 42 4
The sum of the elements of the main diagonal: 1+9+2 = 12
*/



try
{
    int m = ReadInt("Enter m");
    int n = ReadInt("Enter n");
    int[,] array = Create2DArray(m, n);
    Print2DArray(array);
    Console.WriteLine();
    int sum = FindElements(array);
    PrintElements(sum);
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


int FindElements(int[,] array)
{
    int sum = 0;
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            if (i == j) sum += array[i, j];
        }
    }
    return sum;
}

void PrintElements(int sum)
{
    Console.WriteLine($"Sum of elements on the main diagonal = {sum}");
}