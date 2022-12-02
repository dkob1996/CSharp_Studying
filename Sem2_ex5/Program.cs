//16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
//5, 25 -> да -4, 16 -> да 25, 5 -> да 8,9 -> нет

int randomNumber1 = int.Parse(Console.ReadLine());                //ввод первой переменной с клавиатуры
int randomNumber2 = int.Parse(Console.ReadLine());                //ввод второй переменной с клавиатуры

if ((randomNumber1 * randomNumber1 == randomNumber2) | (randomNumber2 * randomNumber2 == randomNumber1))
{
        Console.WriteLine("да");  
}
else
{
        Console.WriteLine("нет");
}

//Второе решение задачи
// Console.Write("Enter first num ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter second num ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if((Math.Pow(num1, 2)==num2)|(Math.Pow(num2, 2)==num1)) 
// {
//    Console.WriteLine("One number is the square of the second ");
// }
// else
// {
//    Console.WriteLine("One number is not the square of the second ");
// }
