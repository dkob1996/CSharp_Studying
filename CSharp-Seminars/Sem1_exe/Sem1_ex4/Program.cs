//Write a program that takes a single number (N) as input and outputs all integers between -N and N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 2 -> "-2, -1, 0, 1, 2"

Console.WriteLine("Enter number");                   //Number input message
int num = int.Parse(Console.ReadLine());             //Entering a number from the keyboard
for (var count = -num; count <= num; count++)        //Loop counter = - number, as long as counter is less than or equal to number, counter +1
{
        Console.WriteLine(count);                    //Print numbers from -num to num
}