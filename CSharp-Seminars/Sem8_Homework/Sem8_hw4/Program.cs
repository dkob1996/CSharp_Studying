/*
Task 60. ...Form a three-dimensional array of non-repeating two-digit numbers. Write a program
that will output an array line by line, adding indexes of each element.
Array size 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/


try
{
    Console.WriteLine("Enter the dimension a x b x c.");
    int a = ReadInt("Enter a:");
    int b = ReadInt("Enter b:");
    int c = ReadInt("Enter c:");
    Console.WriteLine();

    int[,,] A = Create3DArray(a, b, c);
    Console.WriteLine("Array:");
    Print3DArray(A);
    Console.WriteLine();

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


void Print3DArray(int[,,] array)                         //Method of printing a three-dimensional array
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var k = 0; k < array.GetLength(2); k++)
        {
            for (var j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, k]} {(i, j, k)};" + " ");
            }
        }
        Console.WriteLine();
    }
}


int[,,] Create3DArray(int m, int n, int k)               //A method for creating a three-dimensional array filled with random numbers
{
    Random random = new Random();
    int[,,] array = new int[m, n, k];
    int temp = random.Next(1, 100);

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            for (var g = 0; g < array.GetLength(2); g++)
            {
                while (CheckTheRepeatetElement(array, temp))
                {
                    temp = random.Next(1, 100);
                }
                array[i, j, g] = temp;
            }
        }
    }
    return array;
}

int ReadInt(string title)                                //The method of entering numbers from the keyboard
{
    Console.WriteLine(title);

    bool isParsed = int.TryParse(Console.ReadLine(), out int number);

    if (isParsed)
    {
        return number;
    }

    throw new Exception("Incorrect symbols have been entered");
}

bool CheckTheRepeatetElement(int[,,] array, int value)   //Method of checking random elements for uniqueness
{
    foreach (var item in array)
    {
        if (item == value)
        {
            return true;
        }
    }
    return false;
}