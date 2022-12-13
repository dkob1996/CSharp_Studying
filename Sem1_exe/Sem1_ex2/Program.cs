//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да a = 2, b = 10 -> нет a = 9, b = -3 -> да a = -3 b = 9 -> нет
//20 мин


int numberA = int.Parse(Console.ReadLine());     //Ввод первого числа с клавиатуры
int numberB = int.Parse(Console.ReadLine());     //Ввод второго числа с клавиатуры

if ((numberB * numberB) == numberA)              
{
    Console.WriteLine("Good");
}
else
{
    Console.WriteLine("Bad");
}