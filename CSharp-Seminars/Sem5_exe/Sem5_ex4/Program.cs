/*
Task 35: Set a one-dimensional array of 123 random numbers.
Find the number of array elements whose values lie in
the segment [10,99].
Example for an array of 5, not 123 elements. In your solution, do for 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/
Console.WriteLine("Number of elements with values from [10,99]:");
int[] array = RandomZeroOne(123);

PrintArray(array);

int CountOfNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            count++;
        }
    }
    return count;
}

int Counter = CountOfNumbers(array);
Console.WriteLine(Counter);






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
        array[i] = rand.Next(1, 124);
    }
    return array;
}

