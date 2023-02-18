//Task 8: Write a program that takes a number (N) as input and outputs all even numbers from 1 to N.
//
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Enter number N");
int number = int.Parse(Console.ReadLine());

for (var count = 1; count <= number; count++)        
{
    if (count % 2 == 0)
    {
        Console.WriteLine(count);                    
    }
}