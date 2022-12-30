/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

try
{
    int N = ReadInt("Введите N:");
    int startNumber = 1;
    Console.WriteLine();
    CountOfN(startNumber, N);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

void CountOfN(int startNumber, int N)                          //Метод вывода чисел от N до 1
{
    if (startNumber > N)
    {
        return;
    }
    Console.Write($"{N}" + ";" + " ");
    CountOfN(startNumber, N - 1);

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
