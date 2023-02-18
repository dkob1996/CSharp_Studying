/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> 
(-0,5; -0,5)

b1 = 2, k1 = 5, b2 = 4, k2 = 5 
Параллельны

b1 = 2, k1 = 5, b2 = 2, k2 = 5 
Совпадают
*/

double b1 = EnterNumber("Введите число b1: ");                                                  //вводим переменные с клавиатуры
double k1 = EnterNumber("Введите число k1: ");
double b2 = EnterNumber("Введите число b2: ");
double k2 = EnterNumber("Введите число k2: ");

(double, double, bool, bool) FindComasOfCrossroad(double b1, double k1, double b2, double k2)   //метод по поиску пересечений
{
    double findX = 0;
    double findY = 0;
    bool cross = true;
    bool parallel = false;

    if (k1 != k2)
    {
        findX = (b2 - b1) / (k1 - k2);
        findY = (b1 * k2 - b2 * k1) / (k2 - k1);
        cross = true;
    }
    if ((k1 == k2) && (b1 != b2))
    {
        cross = false;
    }
    if ((k1 == k2) && (b1 == b2))
    {
        parallel = true;
    }
    return (findX, findY, cross, parallel);

}

(double, double, bool, bool) CoordsAndFlags = FindComasOfCrossroad(b1, k1, b2, k2);                   //обращение к методу по поиску пересечений


PrintAnswer(CoordsAndFlags);                                                                         //обращение к методу по выводу x,y или другого ответа


void PrintAnswer((double, double, bool, bool) CoordsAndFlags)                                        //метод вывода сообщения
{
    if ((CoordsAndFlags.Item3 == true) && (CoordsAndFlags.Item4 == false))
    {
        Console.WriteLine($"Координаты пересечения - x: {CoordsAndFlags.Item1}, y: {CoordsAndFlags.Item2}");
    }
    if (CoordsAndFlags.Item4 == true)
    {
        Console.WriteLine("Прямые совпадают");
    }
    if (CoordsAndFlags.Item3 == false)
    {
        Console.WriteLine("Прямые параллельны");
    }
}


double EnterNumber(string text)                                                                         //метод печати сообщения при вводе переменных
{
    bool isParsed = false;
    double number = 0;

    while (!isParsed)
    {
        Console.Write(text);
        isParsed = double.TryParse(Console.ReadLine(), out number);
    }
    return number;
}