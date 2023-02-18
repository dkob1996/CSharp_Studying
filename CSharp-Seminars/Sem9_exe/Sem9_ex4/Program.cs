/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (35) A = 2; B = 3 -> 8
*/


try
{
    int A = ReadInt("Введите A:");
    int B = ReadInt("Введите B:");
    int tmp = 1;
    Console.WriteLine();
    int Result = GetInDegree(tmp, A, B);
    PrintAnswer(Result, A,B);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

int GetInDegree(int tmp, int A, int B)                                    //Метод возведения в степень
{
    if (B == 0)
    {
        return tmp;
    }
    else
    {
        tmp *= A;
        B--;
    }
    return GetInDegree(tmp, A, B);

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


void PrintAnswer(int Result, int A, int B)                    //Метод вывода ответа
{
    Console.WriteLine($"[{A}] в степени [{B}] = {Result}.");
}