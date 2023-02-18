// 9. Write a program that outputs a random number
// from the segment [10, 99] and shows the largest digit of the number.
// 78 -> 8 12-> 2 85 -> 8

Random random = new Random();

int randomNumber = random.Next(10,100);

int lastDigit = randomNumber % 10;
int firstDigit = randomNumber / 10 % 10;

if (lastDigit > firstDigit)
{
    Console.WriteLine(lastDigit);
}
else
{
    Console.WriteLine(firstDigit);
}

Console.WriteLine(randomNumber);
Console.WriteLine(lastDigit);
Console.WriteLine(firstDigit);