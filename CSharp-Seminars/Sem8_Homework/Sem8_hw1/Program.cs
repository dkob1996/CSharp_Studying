/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/


try
{
    int m = ReadInt("Введите кол-во столбцов:");
    int n = ReadInt("Введите кол-во строк:");
    int[,] array = Create2DArray(m, n);
    Console.WriteLine("Исходный массив:");
    Print2DArray(array);
    Console.WriteLine();
    SelectionSortForMaxToMin(array);
    Console.WriteLine("Отсортированный массив:");
    Print2DArray(array);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

void Print2DArray(int[,] array)                                //Метод печати двумерного массива
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

int[,] Create2DArray(int m, int n)                             //Метод создания двумерного массива
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

void Sort1DMassive(int[] tempArray)                            //Метод сортировки одномерного массива(пузрьком) от макс к мин
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

void RepairValuesInStringsOrColumns(bool isRow, int index, int[] Source1DMassive, int[,] Sourse2DMassive)   //Метод замены отсортированной строчки
{
    for (int k = 0; k < Source1DMassive.Length; k++)
    {
        if (isRow)
            Sourse2DMassive[index, k] = Source1DMassive[k];
        else
            Sourse2DMassive[k, index] = Source1DMassive[k];
    }
}

void SelectionSortForMaxToMin(int[,] array)                    //Метод сортировки двумерного массива с вызовом других методов
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


int ReadInt(string title)                                      //Метод ввода чисел с клавиатуры
{
    Console.WriteLine(title);

    bool isParsed = int.TryParse(Console.ReadLine(), out int number);

    if (isParsed)
    {
        return number;
    }

    throw new Exception("Введены не корректные символы");
}

