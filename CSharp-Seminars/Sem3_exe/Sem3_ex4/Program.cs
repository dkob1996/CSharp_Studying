//Task No22. Working in groups
//Write a program that takes a number (N) as input and outputs a table of squares of numbers
// from 1 to N.
//● 5 -> 1, 4, 9, 16, 25.
//● 2 -> 1,4

Console.WriteLine("Enter number N");
int a = int.Parse(Console.ReadLine());

for (var i = 1; i <= a; i++)
{
    double result = Math.Pow(i, 2);
    Console.Write(result);
    Console.Write(";");
}