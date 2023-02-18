//Task 29: Write a program that sets an array of 8 elements and displays them on the screen.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Enter count elements of massive");
int ElementCount = int.Parse(Console.ReadLine());

int[] array = CreateMassive(ElementCount);

PrintArray(array);
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (var i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]},");
    }
    Console.Write(array[arr.Length - 1]);
    Console.Write("]");
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