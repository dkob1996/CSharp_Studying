/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/


try
{
    int m = ReadInt("Введите кол-во столбцов A:");
    int n = ReadInt("Введите кол-во строк A:");

    int k = ReadInt("Введите кол-во столбцов B:");
    int g = ReadInt("Введите кол-во строк B:");

    Console.WriteLine();
    int[,] A = Create2DArray(m, n);
    Console.WriteLine("Массив A:");
    Print2DArray(A);
    Console.WriteLine();

    int[,] B = Create2DArray(k, g);
    Console.WriteLine("Массив B:");
    Print2DArray(B);
    Console.WriteLine();

    (int[,] C, int flag) = MultiplyOfAAndB(A, B);
    PrintAnswerOfMultiply(C, flag);

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

void Print2DArray(int[,] array)                         //Метод печати двумерного массива
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

int[,] Create2DArray(int m, int n)                      //Метод создания двумерного массива заполненого случайными числами
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

int ReadInt(string title)                               //Метод ввода чисел с клавиатуры
{
    Console.WriteLine(title);

    bool isParsed = int.TryParse(Console.ReadLine(), out int number);

    if (isParsed)
    {
        return number;
    }

    throw new Exception("Введены не корректные символы");
}

(int[,], int) MultiplyOfAAndB(int[,] A, int[,] B)       //Метод перемножения матриц
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

void PrintAnswerOfMultiply(int[,] C, int flag)          //Метод печати ответа перемножения или невыполнения условий
{
    if (flag == 1)
    {
        Console.WriteLine("Массив C = A x B:");
        Print2DArray(C);
    }
    else Console.WriteLine("Кол-во строк A должно быть равно кол-ву столбцов B!");

}