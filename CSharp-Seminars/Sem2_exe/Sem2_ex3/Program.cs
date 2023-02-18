//Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли первое число кратным второму. Если число 2 не кратно числу 1, 
//то программа выводит остаток от деления. 34, 5 -> не кратно, остаток 4 16, 4 -> кратно

//int randomNumber1 = int.Parse(Console.ReadLine());
//int randomNumber2 = int.Parse(Console.ReadLine());

Random random = new Random();                          //объявление случайности

int randomNumber1 = random.Next(10,100);               //присвоение случайного числа переменной
int randomNumber2 = random.Next(1,10);                 //присвоение случайного числа переменной

Console.WriteLine(randomNumber1);                      //вывод на экран первой случайно переменной
Console.WriteLine(randomNumber2);                      //вывод на экран второй случайно переменной

int result = randomNumber1 % randomNumber2;            //остаток от деления 1ого на 2ое число

if ((result) != 0)                                     //если 1ое число не кратно второму то
{
    Console.WriteLine(result);                         //вывод остатка от деления
}
else
{
    Console.WriteLine("кратно");                       //иначе вывод "кратно"
}