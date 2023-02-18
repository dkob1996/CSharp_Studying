//Task 15: Write a program that accepts a digit indicating the day of the week as input and checks whether this day is a weekend.
//
//6 - > yes
//7 -> yes
//1 -> no

Console.WriteLine("Enter the number of the day of the week to check if it is a day off");
int day = int.Parse(Console.ReadLine());

if ((day >0) && (day < 8))
{
    if (day < 6)
    {
        Console.WriteLine("No");
    }
    else
    {
        Console.WriteLine("Yes");
    }
}
else
{
    Console.WriteLine("Enter the correct number of the day of the week");
}