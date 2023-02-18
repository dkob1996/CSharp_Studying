//16. Write a program that takes two numbers as input and checks whether one number is the square of the other.
////5, 25 -> yes -4, 16 -> up to 25, 5 -> yes 8,9 -> no

int randomNumber1 = int.Parse(Console.ReadLine());                //entering the first variable from the keyboard
int randomNumber2 = int.Parse(Console.ReadLine());                //entering the second variable from the keyboard

if ((randomNumber1 * randomNumber1 == randomNumber2) | (randomNumber2 * randomNumber2 == randomNumber1))
{
        Console.WriteLine("yes");  
}
else
{
        Console.WriteLine("no");
}

//The second solution of the problem
/*
 Console.Write("Enter first num ");
 int num1 = Convert.ToInt32(Console.ReadLine());
 Console.Write("Enter second num ");
 int num2 = Convert.ToInt32(Console.ReadLine());
 if((Math.Pow(num1, 2)==num2)|(Math.Pow(num2, 2)==num1)) 
 {
    Console.WriteLine("One number is the square of the second ");
 }
 else
 {
    Console.WriteLine("One number is not the square of the second ");
 }
 */
