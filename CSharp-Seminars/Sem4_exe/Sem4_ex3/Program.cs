//Task 28: Write a program that takes the number N as input and outputs the product of numbers from 1 to N.
//4->24 5->120


int number = EnterNumber("Enter number: ");

Console.WriteLine(MultipleNumbers(number));

int MultipleNumbers(int num)
{
    int mult = 1;
    for (int i = 1; i<= num; i++)
    {
        mult *=i;
    }
    return mult;
}

int EnterNumber(string text)
{
    bool isParsed = false;
    int number = 0;

    while (!isParsed)
    {
Console.Write(text);
isParsed = int.TryParse(Console.ReadLine(), out number);
    }
    return number;
}
