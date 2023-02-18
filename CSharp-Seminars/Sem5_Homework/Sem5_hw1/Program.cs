//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


Console.WriteLine("Введите кол-во элементов в массиве");
int NumbersOfElements = int.Parse(Console.ReadLine());

int[] array = RandomZeroOne(NumbersOfElements);
PrintArray(array);


int CountOfNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int CountNumb = CountOfNumbers(array);
Console.WriteLine($"Количество четных чисел в массиве :{CountNumb}");


void PrintArray(int[] arr)
{
    Console.WriteLine("Массив случайных чисел");
    Console.Write("[");
    for (var i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]},");
    }
    Console.Write(array[arr.Length - 1]);
    Console.WriteLine("]");
}

int[] RandomZeroOne(int NumbersOfElements)
{
    int[] array = new int[NumbersOfElements];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(100, 1000);
    }
    return array;
}

