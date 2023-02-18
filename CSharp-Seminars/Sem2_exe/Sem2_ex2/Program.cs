//Напишите программу, которая выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа. 456 -> 46 782 -> 72 918 -> 98

Random random = new Random();               //объявляем метод случайный

int randomNumber = random.Next(99,1000);    //обьявляем случайное трехзначное

int lastDigit = randomNumber % 10;          //находим последнее число
int firstDigit = randomNumber /100;         //находим первое число
int result = (firstDigit * 10) + lastDigit; //складываем второе число с первым умноженным на 10

Console.WriteLine(randomNumber);
Console.WriteLine(lastDigit);
Console.WriteLine(firstDigit);
Console.WriteLine(result);                  //вывод финального числа