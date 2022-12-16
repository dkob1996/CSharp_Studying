/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.WriteLine("Введите количество элементов массива");
int M = int.Parse(Console.ReadLine());

int[] array = CreateMassive(M);

PrintArray(array);

int counter = CountOfNonZeroElements(array);

void PrintArray(int[] arr)
{
    Console.WriteLine("Массив:");
    Console.Write("[");
    for (var i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]},");
    }
    Console.Write(array[arr.Length - 1]);
    Console.WriteLine("]");
}

int[] CreateMassive(int number)
{
    int[] array = new int[number];
    Console.WriteLine("Введите подряд через Enter элементы массива");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

int CountOfNonZeroElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine($"Количество положительных чисел : {counter}");