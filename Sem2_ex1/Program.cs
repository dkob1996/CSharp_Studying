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