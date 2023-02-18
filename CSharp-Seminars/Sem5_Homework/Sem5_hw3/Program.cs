/*
Task 38: Specify an array of real numbers.
Find the difference between the maximum and minimum array elements.
[3 7 22 2 78] -> 76
*/



Console.WriteLine("Enter count of elements in massive");
int NumbersOfElements = int.Parse(Console.ReadLine());

double[] array = RandomZeroOne(NumbersOfElements);
PrintArray(array);

(double, double) FindMaxAndMin(double[] array)           //Finding max and min
{
    double MaxElem = array[0];
    double MinElem = array[0];

    for (var i = 1; i < array.Length; i++)
    {
        if (array[i] > MaxElem)
        {
            MaxElem = array[i];
        }
        else
        {
            if (array[i] < MinElem)
            {
                MinElem = array[i];
            }
        }
    }
    return (MaxElem, MinElem);
}

(double, double) MaxAndMinElements = FindMaxAndMin(array);

Console.Write("Max element in massive:");
Console.WriteLine(MaxAndMinElements.Item1);
Console.Write("Min element in massive:");
Console.WriteLine(MaxAndMinElements.Item2);

Console.Write("The difference between the maximum and minimum array elements:");
double result = 0;
if (MaxAndMinElements.Item2 < 0 && MaxAndMinElements.Item1 < 0)
{
    result = MaxAndMinElements.Item2 - MaxAndMinElements.Item1;
}
if ((MaxAndMinElements.Item2 < 0 && MaxAndMinElements.Item1 > 0))
{
    result = MaxAndMinElements.Item2 + MaxAndMinElements.Item1;
}
if ((MaxAndMinElements.Item2 > 0 && MaxAndMinElements.Item1 > 0))
{
    result = MaxAndMinElements.Item1 - MaxAndMinElements.Item2;
}
Console.WriteLine(result);


void PrintArray(double[] arr)
{
    Console.WriteLine("Array of random numbers:");
    Console.Write("[");
    for (var i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]},");
    }
    Console.Write(array[arr.Length - 1]);
    Console.WriteLine("]");
}

double[] RandomZeroOne(int NumbersOfElements)
{
    double[] array = new double[NumbersOfElements];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(-42.132 + rand.NextDouble() * (7.003 + 42.132), 13);
    }
    return array;
}

