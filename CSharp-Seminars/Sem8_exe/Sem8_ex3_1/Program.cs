/*Specify a two-dimensional array of integers. Write a program
that will delete the row and column at the intersection of which the smallest element of the array is located.*/


int m = InputInt("Enter the number of lines: ");
int n = InputInt("Enter the number of columns: ");
int[,] array = Create2DRandomArray(m, n);
Print2DArray(array);
Console.WriteLine(FindMin(array));
Console.WriteLine();
Print2DArray(DeletLineAndColumn(array));

int[,] DeletLineAndColumn(int[,] array)
{
    (int line, int column) minIndex = FindMin(array);
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0, m = 0; i < array.GetLength(0); i++)
    {
        if (i != minIndex.line)
        {
            for (int j = 0, n=0; j < array.GetLength(1); j++)
            {
                if (j != minIndex.column)
                {
                    newArray[m, n] = array[i, j];
                    n++;
                }

            }
            m++;
        }

    }
    return newArray;
}

(int, int) FindMin(int[,] array)
{
    (int line, int column) minIndex = (0, 0);
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
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

int[,] Create2DRandomArray(int m, int n)
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

int InputInt(string text)
{
    bool isParsed = false;
    int number = 0;

    while (!isParsed)
    {
        Console.Write(text);
        isParsed = int.TryParse(Console.ReadLine(), out number);
    }
    return number;
}