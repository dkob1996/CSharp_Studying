// 2. Write a program that outputs a random three-digit number
// and deletes the second digit of this number. 456 -> 46 782 -> 72 918 -> 98

Random random = new Random();               //declaring a random method

int randomNumber = random.Next(99,1000);    //declaring a random three - digit

int lastDigit = randomNumber % 10;          //find the last number
int firstDigit = randomNumber /100;         //we find the first number
int result = (firstDigit * 10) + lastDigit; //add the second number with the first multiplied by 10

Console.WriteLine(randomNumber);
Console.WriteLine(lastDigit);
Console.WriteLine(firstDigit);
Console.WriteLine(result);                  //output of the final number