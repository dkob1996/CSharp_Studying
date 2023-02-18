/*
Task 45: Write a program that will create a copy of a given array using
piecemeal copying.
*/

Console.WriteLine("Enter the number of array elements");
int ElementCount = int.Parse(Console.ReadLine());

int[] array = CreateMassive(ElementCount);
int[] mass = CoppyMassive(array, ElementCount);

PrintArray(mass);
void PrintArray(int[] arr)
{
    Console.WriteLine("Copied array:");
    Console.Write("[");
    for (var i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]},");
    }
    Console.Write(mass[arr.Length - 1]);
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

int[] CoppyMassive(int[] array, int ElementCount)
{
    int[] mass = new int[ElementCount];
    for (int i=0; i<array.Length; i++)
    {
        mass[i] = array[i];
    }
    return mass;
}

