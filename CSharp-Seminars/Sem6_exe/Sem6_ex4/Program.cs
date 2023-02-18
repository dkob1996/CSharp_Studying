/*
Task 44: Without using recursion, output the first
N Fibonacci numbers. The first two Fibonacci numbers are: 0 and
1.
If N = 5 -> 0 1 1 2 3 
If N = 3 -> 0 1 1
If N = 7 -> 0 1 1 2 3 5 8
*/

Console.WriteLine("Enter the number of Fibonacci numbers:");
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
    Console.WriteLine("Array of Fibonacci numbers:");
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