//Task 36: Set a one-dimensional array filled with random numbers. Find the sum of the elements standing in odd positions.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0



Console.WriteLine("Enter count elements in massive");
int NumbersOfElements = int.Parse(Console.ReadLine());

int[] array = RandomZeroOne(NumbersOfElements);
PrintArray(array);


int SumOfNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            count = count + array[i];
        }
    }
    return count;
}

int SumNumb = SumOfNumbers(array);
Console.WriteLine($"The sum of the elements standing in odd positions :{SumNumb}");


void PrintArray(int[] arr)
{
    Console.WriteLine("Array of random numbers");
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
        array[i] = rand.Next(-100, 100);
    }
    return array;
}

