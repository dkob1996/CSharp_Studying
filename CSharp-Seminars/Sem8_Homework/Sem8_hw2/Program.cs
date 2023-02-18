/*
Task 56: Define a rectangular two-dimensional array. Write a program that will find the string with the smallest sum of elements.

For example, an array is given:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

The program counts the sum of elements in each row and outputs the row number with the smallest sum of elements: 1 row.
Note: output the index of the desired row.
*/

try
{
    int m = ReadInt("Enter the number of columns:");
    int n = ReadInt("Enter the number of lines:");
    Console.WriteLine();
    int[,] array = Create2DArray(m, n);
    Print2DArray(array);
    Console.WriteLine();
    int[] result = FindSumInStrings(array);
    PrintAnswer(result);
    Console.WriteLine();
    (int, int) FindedString = StringsCompassions(result);
    (int[], int) RepeatedInexes = FindRepeatetIndex(result, FindedString);
    Console.WriteLine();
    PrintResultCompassion(FindedString, RepeatedInexes);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

void Print2DArray(int[,] array)                         //Two-dimensional array printing method
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

int[,] Create2DArray(int m, int n)                      //A method for creating a two-dimensional array filled with random numbers
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

int ReadInt(string title)                               //The method of entering numbers from the keyboard
{
    Console.WriteLine(title);

    bool isParsed = int.TryParse(Console.ReadLine(), out int number);

    if (isParsed)
    {
        return number;
    }

    throw new Exception("Incorrect symbols have been entered");
}

int[] FindSumInStrings(int[,] array)                    //Method for summing the values of elements in array rows
{
    int[] mass = new int[array.GetLength(0)];
    int[] result = new int[array.GetLength(0)];

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            result[i] = result[i] + array[i, j];
        }
        mass[i] += result[i];
    }
    return mass;
}

void PrintAnswer(int[] result)                          //The method of printing the summation array (mainly needed for verification)
{
    Console.WriteLine("Sums of elements in rows:");
    for (var i = 0; i < result.Length; i++)
    {
        Console.Write(result[i] + ";" + " ");
    }
}

(int, int) StringsCompassions(int[] result)             //The method of finding the minimum string in the array of the sum of strings
{
    int MinIndex = 0;
    int MinString = result[0];
    for (var i = 0; i < result.Length; i++)
    {
        if (result[i] < MinString)
        {
            MinString = result[i];
            MinIndex = i;
        }
    }
    return (MinIndex, MinString);
}

(int[], int) FindRepeatetIndex(int[] result, (int, int) FindedString)              //A method for finding duplicate minimal elements
{
    int flag = -1;
    int[] RepeatetIndexes = new int[result.Length];
    for (int i = 0, n = 0; i < result.Length; i++)
    {
        if (result[i] == FindedString.Item2)
        {
            RepeatetIndexes[n] = 1 + i;
            n++;
            flag++;
        }
    }
    //   Console.WriteLine($"Флаг:{flag}");
    return (RepeatetIndexes, flag);
}

void PrintResultCompassion((int, int) FindedString, (int[], int) RepeatedInexes)   //The method of printing the results of comparing the sum of the elem lines
{
    if (RepeatedInexes.Item2 <= 0)
    {
        Console.WriteLine($"String No. {FindedString.Item1} with the smallest number of elements (count = {FindedString.Item2}).");
    }
    if (RepeatedInexes.Item2 > 0)
    {
        Console.WriteLine("There were several identical lines with a minimum value in the array!");
        Console.WriteLine($"Element values = {FindedString.Item2}. Indexes of these elements:");
        for (var i = 0; i < RepeatedInexes.Item1.Length; i++)
        {
            if (RepeatedInexes.Item1[i] != 0) Console.Write(RepeatedInexes.Item1[i] - 1 + ";" + " ");
        }
    }
}