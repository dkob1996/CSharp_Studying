//Задача 24: Напишите программу, которая принимает на вход число (А) 
//и выдаёт сумму чисел от 1 до А.
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