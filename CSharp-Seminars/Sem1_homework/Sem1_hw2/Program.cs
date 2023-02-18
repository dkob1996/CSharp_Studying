//Task 4: Write a program that takes three numbers as input and outputs the maximum of these numbers.
//
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Enter three numbers to compare");
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