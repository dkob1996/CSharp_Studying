//keyboard input as long as numbers and not words are entered

bool isParsed = false;
int number = 0;
while (isParsed == false)
{
    isParsed = int.TryParse(Console.ReadLine(), out number);
    if(isParsed == false)
    {
        Console.WriteLine("Write the numbers!");
    }
}
