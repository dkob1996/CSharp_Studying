//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3 78 -> 2 89126 -> 5

int number = EnterNumber("Введите число: ");

Console.WriteLine(CountDigitInNumber(number));

int CountDigitInNumber(int number)
{
    int count = 0;
    while (number != 0)
    {
        count++;
        number /=10;
    }
    return count;
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
