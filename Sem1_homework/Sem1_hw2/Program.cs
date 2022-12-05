//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите три числа для сравнения");
int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());
int numberC = int.Parse(Console.ReadLine());
int max = 0;

if ((numberA > numberB) && (numberA > numberC))
{
    max = numberA;
}
else
{
    if (numberB > numberC)
    {
        max = numberB;
    }
    else
    {
        max = numberC;
    }
}
Console.WriteLine(max);