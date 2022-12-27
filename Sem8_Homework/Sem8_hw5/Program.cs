/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

try
{
    int m = ReadInt("Введите кол-во столбцов:");
    int n = ReadInt("Введите кол-во строк:");

    Console.WriteLine();
    int[,] array = new int[m, n];
    Create2DSpiralArray(array);
    Console.WriteLine("Спиральный массив:");
    Print2DArray(array);
    Console.WriteLine();

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

void Create2DSpiralArray(int[,] array)                  //Метод заполнения спирально двумерного массива
{
    int hight = array.GetLength(0);
    int width = array.GetLength(1);

    int s = 1; 
                                            
    for (int y = 0; y < width; y++)                      //Заполнение первого периметра
    {
        array[0, y] = s;
        s++;
    }
    for (int x = 1; x < hight; x++)
    {
        array[x, width - 1] = s;
        s++;
    }
    for (int y = width - 2; y >= 0; y--)
    {
        array[hight - 1, y] = s;
        s++;
    }
    for (int x = hight - 2; x > 0; x--)
    {
        array[x, 0] = s;
        s++;
    }

    int c = 1;                                   //инициализируем начальные координаты второго круга
    int d = 1;

    while (s < hight * width)
    {
        while (array[c, d + 1] == 0)             //вправо
        {
            array[c, d] = s;
            s++;
            d++;
        }

        while (array[c + 1, d] == 0)            //вниз
        {
            array[c, d] = s;
            s++;
            c++;
        }

        while (array[c, d - 1] == 0)            //влево
        {
            array[c, d] = s;
            s++;
            d--;
        }

        while (array[c - 1, d] == 0)            //вверх
        {
            array[c, d] = s;
            s++;
            c--;
        }
    }

    for (int x = 0; x < hight; x++)            //заполняем последнее значение в центре
    {
        for (int y = 0; y < width; y++)
        {
            if (array[x, y] == 0)
            {
                array[x, y] = s;
            }
        }
    }
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
