//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Напишите сначала число 'a', а затем число 'b'");
int numberA = int.Parse(Console.ReadLine());      //Ввод первого числа с клавиатуры
int numberB = int.Parse(Console.ReadLine());     //Ввод второго числа с клавиатуры
int max = 0;

if (numberA == numberB)
{
    Console.WriteLine("Числа 'a' и 'b' одинаковы");
}
else
{
    if (numberA > numberB)
    {
        max = numberA;
    }
    else
    {
        max = numberB;
    }
    Console.WriteLine(max);
}
