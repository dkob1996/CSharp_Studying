/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка.
Примечание: вывести индекс нужной строки.
*/

try
{
    int m = ReadInt("Введите кол-во столбцов:");
    int n = ReadInt("Введите кол-во строк:");
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

int[] FindSumInStrings(int[,] array)                    //Метод суммирования значения элементов в сроках массива
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

void PrintAnswer(int[] result)                          //Метод печати массива суммирования (в основном надо для проверки)
{
    Console.WriteLine("Суммы элементов в строках:");
    for (var i = 0; i < result.Length; i++)
    {
        Console.Write(result[i] + ";" + " ");
    }
}

(int, int) StringsCompassions(int[] result)             //Метод поиска минимальной строки в массиве суммы строк
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

(int[], int) FindRepeatetIndex(int[] result, (int, int) FindedString)              //Метод поиска повторяющихся минимальных элементов
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

void PrintResultCompassion((int, int) FindedString, (int[], int) RepeatedInexes)   //Метод печати результатов сравнения суммы элем-ов строк
{
    if (RepeatedInexes.Item2 <= 0)
    {
        Console.WriteLine($"Строка № {FindedString.Item1} с наименьшим числом элементов (кол-во = {FindedString.Item2}).");
    }
    if (RepeatedInexes.Item2 > 0)
    {
        Console.WriteLine("В массиве оказалось несколько одинаковых строчек с минимальным значением!");
        Console.WriteLine($"Значения элементов = {FindedString.Item2}. Индексы этих элементов:");
        for (var i = 0; i < RepeatedInexes.Item1.Length; i++)
        {
            if (RepeatedInexes.Item1[i] != 0) Console.Write(RepeatedInexes.Item1[i] - 1 + ";" + " ");
        }
    }
}