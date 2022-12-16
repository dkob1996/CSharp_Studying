/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное. 45 -> 101101
3 -> 11
2 -> 10
*/

Console.WriteLine("Введите число для трансформации в двоичное:");
int number = int.Parse(Console.ReadLine());

string number2nd = ConvertTo2nd(number);

Console.WriteLine($"Результат перевода: {number2nd}");

string ConvertTo2nd(int number)
{
    string str = String.Empty;                                  //Пустая строка.
    while (number > 0)
    {
        str = number % 2 + str;
        number /= 2;
    }
    return str;
}
