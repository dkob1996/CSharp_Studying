//Task 23
//Write a program that takes a number (N) as input and outputs a table of cubes of numbers from 1 to N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Enter number N");
int num = int.Parse(Console.ReadLine());
int[] abc = GetCalcTriangles(num);

PrintArray(abc);

int[] GetCalcTriangles(int N)
{
    int[] array = new int[N];
    for (int i = 0; i < N; i++)
    {
        array[i] = (i+1) * (i+1) * (i+1);
    }
    return array;
}

void PrintArray(int []array)
{
    for (int i = 0; i< array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}
