// 3. Write a program that will take two numbers as input and output
// whether the first number is a multiple of the second. If the number 2 is not a multiple of the number 1,
// then the program outputs the remainder of the division. 34, 5 -> not multiple, remainder 4 16, 4 -> multiple

//int randomNumber1 = int.Parse(Console.ReadLine());
//int randomNumber2 = int.Parse(Console.ReadLine());

Random random = new Random();                          //declaration of randomness

int randomNumber1 = random.Next(10,100);               //assigning a random number to a variable
int randomNumber2 = random.Next(1,10);                 //assigning a random number to a variable

Console.WriteLine(randomNumber1);                      //displaying the first random variable
Console.WriteLine(randomNumber2);                      //displaying the second random variable

int result = randomNumber1 % randomNumber2;            //the remainder of the division of the 1st by the 2nd number

if ((result) != 0)                                     //if the 1st number is not a multiple of the second then
{
    Console.WriteLine(result);                         //output of the remainder of the division
}
else
{
    Console.WriteLine("multiply");                     //otherwise, the output is "multiple"
}