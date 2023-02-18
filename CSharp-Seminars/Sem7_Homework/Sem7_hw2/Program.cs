/*
Task 50. Write a program that accepts the positions of an element in a two-dimensional array as input,
and returns the value of this element or an indication that there is no such element.

For example, an array is given:

1 4 7 2
5 9 2 3
8 4 2 4
17 -> there is no such number in the array
*/

// /*
try
{
    int m = ReadInt("Enter m:");
    int n = ReadInt("Enter n:");
    int number = ReadInt("Enter the position of the element in the array:");
    int[,] array = Create2DArray(m, n);
    Print2DArray(array);
    (int, int, int) result = FindNumberInArray(array, number);
    PrintAnswer(result, number);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
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

int[,] Create2DArray(int m, int n)
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

int ReadInt(string title)
{
    Console.WriteLine(title);

    bool isParsed = int.TryParse(Console.ReadLine(), out int number);

    if (isParsed)
    {
        return number;
    }

    throw new Exception("Incorrect symbols have been entered");
}

(int, int, int) FindNumberInArray(int[,] array, int number)
{
    int ind1 = -1;
    int ind2 = -1;
    int result = 0;
    if (number < array.Length)
    {
        if ((array.GetLength(1) % 2 == 0) && (array.GetLength(0) % 2 == 0))   //[even, even]
        {
            if (number < array.GetLength(0))
            {
                result = array[0, number];
                ind1 = 0;
                ind2 = number;
            }
            if (number % array.GetLength(0) == 0)
            {
                ind1 = number / array.GetLength(0);
                ind2 = 0;
                result = array[ind1, ind2];
            }
            if ((number % array.GetLength(0) != 0) && (number - array.GetLength(1) >= 1))
            {
                ind1 = number / array.GetLength(0);
                ind2 = number - (array.GetLength(1) * (number / array.GetLength(0)));
                result = array[ind1, ind2];
            }
        }
        if ((array.GetLength(1) % 2 != 0) && (array.GetLength(0) % 2 == 0))    //[even,odd]
        {
            if (number < array.GetLength(1))
            {
                result = array[0, number];
                ind1 = 0;
                ind2 = number;
            }
            if (number % array.GetLength(1) == 0)
            {
                ind1 = number / array.GetLength(1);
                ind2 = 0;
                result = array[ind1, ind2];
            }
            if ((number % array.GetLength(0) != 0) && (number - array.GetLength(1) >= 1))
            {
                ind1 = number / array.GetLength(1);
                ind2 = number - (array.GetLength(1) * (number / array.GetLength(1)));
                result = array[ind1, ind2];
            }
        }

        if ((array.GetLength(1) % 2 == 0) && (array.GetLength(0) % 2 != 0))  // [odd,even]
        {
            if (number < array.GetLength(1))
            {
                result = array[0, number];
                ind1 = 0;
                ind2 = number;
            }
            if (number % array.GetLength(1) == 0)
            {
                ind1 = number / array.GetLength(0);
                ind2 = 0;
                result = array[ind1, ind2];
            }
            if ((number % array.GetLength(1) != 0) && (number - array.GetLength(1) >= 1))
            {
                ind1 = number / array.GetLength(1);
                ind2 = number - (array.GetLength(1) * (number / array.GetLength(1)));
                result = array[ind1, ind2];
            }
        }

        if ((array.GetLength(1) % 2 != 0) && (array.GetLength(0) % 2 != 0))  // [odd,odd]
        {
            if (number < array.GetLength(1))
            {
                result = array[0, number];
                ind1 = 0;
                ind2 = number;
            }
            if (number % array.GetLength(1) == 0)
            {
                ind1 = number / array.GetLength(0);
                ind2 = 0;
                result = array[ind1, ind2];
            }
            if ((number % array.GetLength(1) != 0) && (number - array.GetLength(1) >= 1))
            {
                ind1 = number / array.GetLength(1);
                ind2 = number - (array.GetLength(1) * (number / array.GetLength(1)));
                result = array[ind1, ind2];
            }
        }

    }
    else result = -1;
    return (result, ind1, ind2);
}

void PrintAnswer((int, int, int) result, int number)
{
    if (result.Item1 != -1) Console.WriteLine($"The element under the number {number}, in the array [{result.Item2},{result.Item3}] is, and it = {result.Item1}.");
    else Console.WriteLine($"There is no element under the number {number} in the array!");
}

// */  




















/*
// Блок проверки условий (для четного массива)
Console.WriteLine("Напишите номер числа:");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Напишите номер array.GetLength(0):");
int gl0 = int.Parse(Console.ReadLine());
Console.WriteLine("Напишите номер array.GetLength(1):");
int gl1 = int.Parse(Console.ReadLine());

int result0 = number % gl0;
Console.WriteLine($"number % array.GetLength(0):{result0}");

int result1 = number / gl0;
Console.WriteLine($"number / array.GetLength(0):{result1}");

int result2 = gl1 * (number / gl0);
Console.WriteLine($"array.GetLength(1) * (number / array.GetLength(0)):{result2}");

int result3 = number - (gl1 * (number / gl0));
Console.WriteLine($"number - (array.GetLength(1) * (number / array.GetLength(0)):{result3}");

//result = array[number % array.GetLength(0), number - (array.GetLength(1) * (number / array.GetLength(0)))];

int ind1 = number / gl0;
Console.WriteLine($"Стобец:{ind1}");

int ind2 = number - (gl1 * (number / gl0));
Console.WriteLine($"Строка:{ind2}");

*/
/*
// Блок проверки условий  (для нечетного массива)
Console.WriteLine("Напишите номер числа:");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Напишите номер array.GetLength(0):");
int gl0 = int.Parse(Console.ReadLine());
Console.WriteLine("Напишите номер array.GetLength(1):");
int gl1 = int.Parse(Console.ReadLine());

int result0 = number / gl1;
Console.WriteLine($"number / array.GetLength(1):{result0}");

int result1 = number / gl1;
Console.WriteLine($"number / array.GetLength(1):{result1}");

int result2 = gl1 * (number / gl1);
Console.WriteLine($"array.GetLength(1) * (number / array.GetLength(1)):{result2}");

int result3 = number - (gl1 * (number / gl1));
Console.WriteLine($"number - (array.GetLength(1) * (number / array.GetLength(1)):{result3}");

//result = array[number / array.GetLength(1), number - (array.GetLength(1) * (number / array.GetLength(1)))];

int ind1 = number / gl1;
Console.WriteLine($"Стобец:{ind1}");

int ind2 = number - (gl1 * (number / gl1));
Console.WriteLine($"Строка:{ind2}");

*/