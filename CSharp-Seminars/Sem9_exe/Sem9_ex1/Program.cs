/*
Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
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

void CountOfN(int startNumber, int N)                          //Метод вывода чисел от startNumber до N
{
    if (startNumber > N)
    {
        return;
    }
    Console.WriteLine(startNumber);
    CountOfN(startNumber+1, N);

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
