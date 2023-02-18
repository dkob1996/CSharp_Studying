//Task 2: Write a program that takes two numbers as input and outputs which number is greater and which is less.
//
//a = 5; b=7 -> max=7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Write the number 'a' first and then the number 'b'");
int numberA = int.Parse(Console.ReadLine());      //Entering the first number from the keyboard
int numberB = int.Parse(Console.ReadLine());     //Entering the second number from the keyboard
int max = 0;

if (numberA == numberB)
{
    Console.WriteLine("The numbers 'a' and 'b' are the same");
}
else
{
    if (numberA > numberB)
    {
        max = numberA;
    }
    else
    {
        max = numberB;
    }
    Console.WriteLine(max);
}
