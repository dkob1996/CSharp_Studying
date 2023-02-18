/*
Задача 44: Не используя рекурсию, выведите первые
N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и
1.
Если N = 5 -> 0 1 1 2 3 Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

Console.WriteLine("Введите количество чисел Фибоначчи:");
int N = int.Parse(Console.ReadLine());

int[] result = CreateFibonacchi(N);

int[] CreateFibonacchi(int N)
{
    int[] array = new int[N];
    if (N > 0) array[0] = 0;
    if (N > 1) array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

PrintArray(result);

void PrintArray(int[] arr)
{
    Console.WriteLine("Массив чисел Фиббоначи:");
    Console.Write("[");
    for (var i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]},");
    }
    Console.Write(result[arr.Length - 1]);
    Console.WriteLine("]");
}

/*
Console.BackgroundColor = ConsoleColor.Red;
Console.ForegroundColor = ConsoleColor.Green;
*/