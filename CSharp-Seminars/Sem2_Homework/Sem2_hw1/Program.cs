//Task 10: Write a program that accepts a
//three-digit number as input and shows the second digit of this number as output.

Random random = new Random(); 

int randomNumber1 = random.Next(100,1000);               

Console.WriteLine(randomNumber1);                      

Console.WriteLine(randomNumber1 / 10 % 10);                         