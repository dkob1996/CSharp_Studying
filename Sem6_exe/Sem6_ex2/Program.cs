/*
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать
треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/

Console.WriteLine("Введите длинну трех сторон треугольника:");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

bool result = TheoryOfTriangles(a, b, c);

Console.WriteLine(result);

bool TheoryOfTriangles(int a, int b, int c)
{
    if ((a < b + c) && (b < a + c) && (c < a + b))
    {
        return true;
    }
    else
    {
        return false;
    }
}