//Задача 13:Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать string[]
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int randomNumber = int.Parse(Console.ReadLine());
int result = 0;               

Console.WriteLine(randomNumber);                      

if (randomNumber >=100)
{
    while (randomNumber > 999)
    {
        randomNumber = randomNumber /10;
    }
    result = randomNumber % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("третьей цифры нет");
}