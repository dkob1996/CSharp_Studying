//Task 33: Specify an array. Write a program that determines whether a given number is present in an array.
//4; array [6, 7, 19, 345, 3] -> no
//3; array [6, 7, 19, 345, 3] -> yes

int[] array = RandomZeroOne(5);
Console.WriteLine("Enter the value of the required number");
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
        Console.WriteLine("There is such a number");
    }
    else
    {
        Console.WriteLine("There is no such number");
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
