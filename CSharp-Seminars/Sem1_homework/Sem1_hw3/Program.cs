//Task 6: Write a program that takes a number as input and outputs whether the number is even (is it divisible by two without a remainder).
//
//4 -> yes
//-3 -> no
//7 -> no

Console.WriteLine("Enter a number to check for parity");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}