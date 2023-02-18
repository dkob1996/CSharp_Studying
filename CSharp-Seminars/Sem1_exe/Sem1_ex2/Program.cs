//Write a program that takes two numbers as input and checks if the first number is the square of the second.
//a = 25, b = 5 -> yes a = 2, b = 10 -> no a = 9, b = -3 -> yes a = -3 b = 9 -> no
//20 minutes


int numberA = int.Parse(Console.ReadLine());     //Entering first number form keyboord
int numberB = int.Parse(Console.ReadLine());     //Entering second number form keyboord

if ((numberB * numberB) == numberA)              
{
    Console.WriteLine("Good");
}
else
{
    Console.WriteLine("Bad");
}