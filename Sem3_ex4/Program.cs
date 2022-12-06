//Задача No22. Работа в группах
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
//от 1 до N.
//● 5 -> 1, 4, 9, 16, 25.
//● 2 -> 1,4

Console.WriteLine("Введите число N");
int a = int.Parse(Console.ReadLine());

for (var i = 1; i <= a; i++)
{
    double result = Math.Pow(i, 2);
    Console.Write(result);
    Console.Write(";");
}