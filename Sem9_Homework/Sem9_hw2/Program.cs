/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N. Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

try
{
    int M = ReadInt("Введите M:");
    int N = ReadInt("Введите N:");
    int tmp = 0;
    Console.WriteLine();
    int Result = GetInDegree(tmp, M, N);
    PrintAnswer(Result, M,N);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

int GetInDegree(int tmp, int M, int N)                           //Метод суммы натуральных элементов от M до N
{
    if (M > N)
    {
        return tmp;
    }
    else
    {
        tmp += M;
        M++;
    }
    return GetInDegree(tmp, M, N);

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



void PrintAnswer(int Result, int M, int N)                    //Метод вывода ответа
{
    Console.WriteLine($"Сумма числе от [{M}] до [{N}] = {Result}.");
}