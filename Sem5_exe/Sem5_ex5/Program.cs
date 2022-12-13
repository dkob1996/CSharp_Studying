/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

Console.WriteLine("Введите кол-во элементов в массиве");
int NumbersOfElements = int.Parse(Console.ReadLine());

int[] array = RandomZeroOne(NumbersOfElements);
PrintArray(array);


int[] ResultOfSumMassive(int[] array)
{
    if (array.Length % 2 == 0)
    {
        int[] sum = new int[array.Length / 2];
        for (int i = 0; i < array.Length - i; i++)
        {
            sum[i] = array[i] + array[array.Length - 1 - i];
        }
        return sum;
    }
    else
    {
        int[] sum = new int[array.Length / 2 + 1];
        for (int i = 0; i < array.Length - i; i++)
        {
            if (i == (array.Length - 1 - i))
            {
                sum[i] = array[i];
            }
            else
            {
                sum[i] = array[i] + array[array.Length - 1 - i];
            }
        }
        return sum;
    }

}



int[] SumMassive = ResultOfSumMassive(array);

PrintSum(SumMassive);

void PrintSum(int[] arr)
{
    Console.WriteLine("Массив суммы чисел");
    Console.Write("[");
    for (var i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]},");
    }
    Console.Write(SumMassive[arr.Length - 1]);
    Console.Write("]");
}



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
        array[i] = rand.Next(1, 10);
    }
    return array;
}

