// 4. Write a program that takes a number as input and checks
// whether it is a multiple of 7 and 23
// at the same time. //14 -> no 46 -> no 161 -> yes

//Random random = new Random();                          //

//int randomNumber1 = random.Next(10,100);               //

//Console.WriteLine(randomNumber1);                      //        

int randomNumber1 = int.Parse(Console.ReadLine());

if (randomNumber1 % 7 ==0 && randomNumber1 % 23 ==0)                 //
{
    Console.WriteLine("yes");                //
}
else
{
    Console.WriteLine("no");              //
}