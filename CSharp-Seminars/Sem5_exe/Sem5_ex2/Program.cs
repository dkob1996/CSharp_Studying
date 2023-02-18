//Task 32: Write a program replacing array elements:
// replace the positive elements with the corresponding negative ones, and vice versa.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.WriteLine("Enter count elements of massive");
int ElementCount = int.Parse(Console.ReadLine());

int[] array2 = CreateMassive(ElementCount);



PrintArray(array2);
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (var i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]},");
    }
    Console.Write(array2[arr.Length - 1]);
    Console.Write("]");
}


int[] CreateMassive(int number)
{
    int[] array2 = new int[number];
    int[] array = new int[number];
    Console.WriteLine("Enter the array elements in a row via Enter");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
        array2[i] = array[i] * (-1);
    }
    return array2;
}

/*int[] ExchangePlusToMinus(int[] array);
{
    int[] array2 = new int[ElementCount];
    for (int i = 0; i < array2.Length; i++)
    {
        array2[i] = array[i] * (-1);
    }
    return array2;
}*/
