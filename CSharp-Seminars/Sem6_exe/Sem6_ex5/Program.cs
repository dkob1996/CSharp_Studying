/*
Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью
поэлементного копирования.
*/

Console.WriteLine("Введите количество элементов массива");
int ElementCount = int.Parse(Console.ReadLine());

int[] array = CreateMassive(ElementCount);
int[] mass = CoppyMassive(array, ElementCount);

PrintArray(mass);
void PrintArray(int[] arr)
{
    Console.WriteLine("Скопированный массив:");
    Console.Write("[");
    for (var i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]},");
    }
    Console.Write(mass[arr.Length - 1]);
    Console.Write("]");
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

int[] CoppyMassive(int[] array, int ElementCount)
{
    int[] mass = new int[ElementCount];
    for (int i=0; i<array.Length; i++)
    {
        mass[i] = array[i];
    }
    return mass;
}

