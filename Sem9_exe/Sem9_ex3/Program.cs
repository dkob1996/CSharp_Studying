/*
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12 45 -> 9
*/


try
{
    int N = ReadInt("Введите число:");
    Console.WriteLine();
    int Result = 0;
    int Sum = SumOfNumbers(Result, N);
    PrintAnswer(Sum);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

int SumOfNumbers(int Result, int N)                                    //Метод возврата суммы цифр числа
{
    if (N <= 0)
    {
        return Result;
    }
    else
    {
    Result += N % 10;
    N /= 10;
    }
    return SumOfNumbers(Result, N);

}

int ReadInt(string title)                                      //Метод ввода чисел с клавиатуры
{
    Console.WriteLine(title);

    bool isParsed = int.TryParse(Console.ReadLine(), out int number);

    if (isParsed)
    {
        return number;
    }

    throw new Exception("Введены не корректные символы");
}


void PrintAnswer(int Sum)
{
    Console.WriteLine(Sum);
}