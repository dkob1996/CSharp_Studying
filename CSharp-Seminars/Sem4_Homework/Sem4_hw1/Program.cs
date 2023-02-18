//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int number1 = EnterNumber("Введите число: ");
int number2 = EnterNumber("Введите степень числа: ");

Console.WriteLine(MultipleNumbers(number1, number2));

double MultipleNumbers(int number1, int number2)
{
    double result = 1;
    if (number2 > 0)
    {
        for (int i = 1; i <= number2; i++)
        {
            result = result * number1;
        }
        return result;
    }
    if (number2 == 0)
    {
        result = 1;
    }
    if (number2 < 0)
    {
        for (int i = 1; i <= Math.Abs(number2); i++)
        {
            result = result / number1;
        }
        return result;
    }
    return result;
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
