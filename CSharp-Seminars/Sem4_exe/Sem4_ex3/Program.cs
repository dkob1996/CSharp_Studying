//Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4->24 5->120


int number = EnterNumber("Введите число: ");

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
