//Task 30: Write a program that outputs an array of 8 elements filled with zeros and ones in random order.
//[1,0,1,1,0,1,0,0]    

int[] array = RandomZeroOne(8);
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
 
int[] RandomZeroOne(int number)
{
    int[] array = new int[number];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0, 2);
    }
    return array;
}