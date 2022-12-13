//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите количество элементов массива");
int ElementCount = int.Parse(Console.ReadLine());

int[] array = CreateMassive(ElementCount);

PrintArray(array);
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (var i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]},");
    }
    Console.Write(array[arr.Length - 1]);
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