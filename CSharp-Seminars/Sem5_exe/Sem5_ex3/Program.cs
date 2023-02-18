//Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да

int[] array = RandomZeroOne(5);
Console.WriteLine("Введите значение необходимого числа");
int NumberFromKey = int.Parse(Console.ReadLine());

PrintArray(array);

int FoundNumb(int[] array, int NumberFromKey)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != NumberFromKey)
        {
            count = count + 0;
        }
        else
        {
            count = count + 1;
        }
    }
    return count;
}

int result = FoundNumb(array, NumberFromKey);
PrintMessage(result);


void PrintMessage(int result)
{
    if (result > 0)
    {
        Console.WriteLine("Такое число есть");
    }
    else
    {
        Console.WriteLine("Такого числа нет");
    }
}




void PrintArray(int[] arr)
{
    Console.Write("[");
    for (var i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]},");
    }
    Console.Write(array[arr.Length - 1]);
    Console.WriteLine("]");
}

int[] RandomZeroOne(int number)
{
    int[] array = new int[number];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(1, 10);
    }
    return array;
}
