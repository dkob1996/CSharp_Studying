//Задача 10: Напишите программу, которая принимает на вход
//трёхзначное число и на выходе показывает вторую цифру этого числа.

Random random = new Random(); 

int randomNumber1 = random.Next(100,1000);               //

Console.WriteLine(randomNumber1);                      //

Console.WriteLine(randomNumber1 / 10 % 10);                         //