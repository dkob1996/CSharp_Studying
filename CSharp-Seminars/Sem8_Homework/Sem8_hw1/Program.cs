/*
Task 54: Define a two-dimensional array. Write a program that will sort the elements of each row of a two-dimensional array in descending order.
For example, an array is given:
1 4 7 2
5 9 2 3
8 4 2 4
The result is an array like this:
7 4 2 1
9 5 3 2
8 4 4 2
*/


try
{
    int m = ReadInt("Enter the number of columns:");
    int n = ReadInt("Enter the number of lines:");
    int[,] array = Create2DArray(m, n);
    Console.WriteLine("Source array:");
    Print2DArray(array);
    Console.WriteLine();
    SelectionSortForMaxToMin(array);
    Console.WriteLine("Sorted array:");
    Print2DArray(array);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

void Print2DArray(int[,] array)                                //Two-dimensional array printing method
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

int[,] Create2DArray(int m, int n)                             //Method for creating a two-dimensional array
{
    int[,] array = new int[m, n];

    Random rand = new Random();

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(1, 10);
        }
    }

    return array;
}

void Sort1DMassive(int[] tempArray)                            //Method of sorting a one-dimensional array (bubble) from max to min
{
    for (int i = 0; i < tempArray.Length; i++)
        for (int j = 0; j < tempArray.Length - i - 1; j++)
        {
            if (tempArray[j] < tempArray[j + 1])
            {
                int temp = tempArray[j];
                tempArray[j] = tempArray[j + 1];
                tempArray[j + 1] = temp;
            }
        }
}

void RepairValuesInStringsOrColumns(bool isRow, int index, int[] Source1DMassive, int[,] Sourse2DMassive)   //Method of replacing the sorted line
{
    for (int k = 0; k < Source1DMassive.Length; k++)
    {
        if (isRow)
            Sourse2DMassive[index, k] = Source1DMassive[k];
        else
            Sourse2DMassive[k, index] = Source1DMassive[k];
    }
}

void SelectionSortForMaxToMin(int[,] array)                    //A method for sorting a two-dimensional array with calling other methods
{

    int colCount = array.GetLength(0);
    int rowCount = array.GetLength(1);

    int[] row = new int[colCount];
    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < colCount; j++) row[j] = array[i, j];

        Sort1DMassive(row);
        RepairValuesInStringsOrColumns(true, i, row, array);
    }
}


int ReadInt(string title)                                      //The method of entering numbers from the keyboard
{
    Console.WriteLine(title);

    bool isParsed = int.TryParse(Console.ReadLine(), out int number);

    if (isParsed)
    {
        return number;
    }

    throw new Exception("Incorrect symbols have been entered");
}

