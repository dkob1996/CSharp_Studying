//Task 13:Write a program that outputs the third digit of a given number or reports that there is no third digit. Don't use string[]
//645 -> 5
//78 -> there is no third digit
//32679 -> 6

Console.WriteLine("Enter a number to determine the third digit");
int randomNumber = int.Parse(Console.ReadLine());
int result = 0;               

Console.WriteLine(randomNumber);                      

if (randomNumber >=100)
{
    while (randomNumber > 999)
    {
        randomNumber = randomNumber /10;
    }
    result = randomNumber % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("there is no third digit");
}