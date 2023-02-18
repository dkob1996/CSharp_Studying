/*
Task 37: Find the product of pairs of numbers in a one-dimensional array. 
We consider the first and last element as a pair, the second and penultimate
, etc. Write the result in a new array. [1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

Console.WriteLine("Enter count elements in massive");
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
    Console.WriteLine("Array of sum of numbers");
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
        array[i] = rand.Next(1, 10);
    }
    return array;
}

