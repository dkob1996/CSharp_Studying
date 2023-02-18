/*
Task 58: Define two matrices. Write a program that will find the product of two matrices.
For example, 2 matrices are given:
2 4 | 3 4
3 2 | 3 3
The resulting matrix will be:
18 20
15 18
*/


try
{
    int m = ReadInt("Enter the number of columns A:");
    int n = ReadInt("Enter the number of lines A:");

    int k = ReadInt("Enter the number of columns B:");
    int g = ReadInt("Enter the number of lines B:");

    Console.WriteLine();
    int[,] A = Create2DArray(m, n);
    Console.WriteLine("Array A:");
    Print2DArray(A);
    Console.WriteLine();

    int[,] B = Create2DArray(k, g);
    Console.WriteLine("Array B:");
    Print2DArray(B);
    Console.WriteLine();

    (int[,] C, int flag) = MultiplyOfAAndB(A, B);
    PrintAnswerOfMultiply(C, flag);

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

void Print2DArray(int[,] array)                         //two-dimensional array printing method
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

(int[,], int) MultiplyOfAAndB(int[,] A, int[,] B)       //Matrix multiplication method
{
    int[,] C = new int[A.GetLength(0), B.GetLength(1)];
    int flag = 1;

    if (A.GetLength(1) == B.GetLength(0))
    {
        for (int i = 0; i < A.GetLength(1); i++)
        {
            for (int j = 0; j < B.GetLength(0); j++)
            {
                for (int k = 0; k < B.GetLength(1); k++)
                {
                    C[i, j] += A[i, k] * B[k, j];
                }
            }
        }
    }
    else flag = -1;
    return (C, flag);
}

void PrintAnswerOfMultiply(int[,] C, int flag)          //The method of printing the response of multiplication or non-fulfillment of conditions
{
    if (flag == 1)
    {
        Console.WriteLine("Array C = A x B:");
        Print2DArray(C);
    }
    else Console.WriteLine("The number of rows A must be equal to the number of columns B!");

}