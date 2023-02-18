/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/


try
{
    int m = ReadInt("Введите m:");
    int n = ReadInt("Введите n:");
    Console.WriteLine();
    int Result = Akkerman(m, n);
    PrintAnswer(Result, m, n);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

int Akkerman(int m, int n)                           //Метод функции Аккермана
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if ((m != 0) && (n == 0))
        {
            return Akkerman(m - 1, 1);
        }
        else
        {
            return Akkerman(m - 1, Akkerman(m, n - 1));
        }
    }

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



void PrintAnswer(int Result, int m, int n)                    //Метод вывода ответа
{
    Console.WriteLine($"A(m,n) = A({m},{n}) = {Result}.");
}