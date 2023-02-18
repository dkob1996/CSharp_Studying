//Task 24: Write a program that accepts a number (A) as input
// and outputs the sum of numbers from 1 to A.
//7 -> 28 4 -> 10 8 -> 36


using Common;

int a = int.Parse(Console.ReadLine());

int sum = GetSumNumbersBetweenOneToNumber(a);

Console.WriteLine(sum);

int GetSumNumbersBetweenOneToNumber(int number)
{
    int sum = 0;
    for (var i=1; i<number; i++)
    {
        sum+=i;
    }
    return sum;
}