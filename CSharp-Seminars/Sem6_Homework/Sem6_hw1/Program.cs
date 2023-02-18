/*
Task 41: The user enters M numbers from the keyboard. Count how many numbers greater than 0 the user entered.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.WriteLine("Enter the number of array elements");
int M = int.Parse(Console.ReadLine());

int[] array = CreateMassive(M);

PrintArray(array);

int counter = CountOfNonZeroElements(array);

void PrintArray(int[] arr)
{
    Console.WriteLine("Massive:");
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
    Console.WriteLine("Enter the array elements in a row via Enter");
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

Console.WriteLine($"Number of positive numbers: {counter}");