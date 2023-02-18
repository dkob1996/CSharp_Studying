/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/


try
{
    Console.WriteLine("Введите размерность a x b x c.");
    int a = ReadInt("Введите a:");
    int b = ReadInt("Введите b:");
    int c = ReadInt("Введите c:");
    Console.WriteLine();

    int[,,] A = Create3DArray(a, b, c);
    Console.WriteLine("Массив:");
    Print3DArray(A);
    Console.WriteLine();

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


void Print3DArray(int[,,] array)                         //Метод печати трехмерного массива
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


int[,,] Create3DArray(int m, int n, int k)               //Метод создания трехмерного массива заполненого случайными числами
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

int ReadInt(string title)                                //Метод ввода чисел с клавиатуры
{
    Console.WriteLine(title);

    bool isParsed = int.TryParse(Console.ReadLine(), out int number);

    if (isParsed)
    {
        return number;
    }

    throw new Exception("Введены не корректные символы");
}

bool CheckTheRepeatetElement(int[,,] array, int value)   //Метод проверки элементов рандома на уникальность
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