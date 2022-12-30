/*
Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5" M = 4; N = 8 -> "4, 6, 7, 8"
*/

try
{
    int M = ReadInt("Введите M:");
    int N = ReadInt("Введите N:");
    Console.WriteLine();
    if (M >= N)
    {
        Console.WriteLine($"Число M=[{M}] должно быть меньше N=[{N}]");
    }
    else
    {
        CountOfN(M, N);
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

void CountOfN(int M, int N)                                    //Метод вывода чисел от M до N
{
    if (M > N)
    {
        return;
    }
    Console.WriteLine(M);
    CountOfN(M + 1, N);

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
