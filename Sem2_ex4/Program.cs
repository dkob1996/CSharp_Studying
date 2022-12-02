//Напишите программу, которая принимает на вход число и проверяет,
//кратно ли оно одновременно 7 и 23.
//14 -> нет 46 -> нет 161 -> да

//Random random = new Random();                          //

//int randomNumber1 = random.Next(10,100);               //

//Console.WriteLine(randomNumber1);                      //        

int randomNumber1 = int.Parse(Console.ReadLine());

if (randomNumber1 % 7 ==0 && randomNumber1 % 23 ==0)                 //
{
    Console.WriteLine("да");                //
}
else
{
    Console.WriteLine("нет");              //
}