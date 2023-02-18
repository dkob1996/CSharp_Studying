//Write a program that takes a three-digit number as input and outputs the last digit of that number.
//456->6 782->2 918->8

Console.WriteLine("Write the number where you need to find the last number");      //displaying an input message
int num = int.Parse(Console.ReadLine());                                           //entering a number from the keyboard
if ((num < 1000) && (num > 99))                                                    //checking if a number is three digits
{
    int result = num % 10;                                                         //writing to a variable the remainder of the division
    Console.WriteLine(result);                                                     //print the remainder of a division
}
else
{
    Console.WriteLine("The number does not match the condition of the problem");   //conclusion that the error
}