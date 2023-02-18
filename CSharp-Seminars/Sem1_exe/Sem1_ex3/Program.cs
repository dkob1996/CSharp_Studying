//Write a program that will output the name of the day of the week given the number.
//3 -> Wednesday 5 -> Friday

Console.WriteLine("Write a number from 1 to 7 inclusive");              //output a message about the rules for entering a number
int day = int.Parse(Console.ReadLine());                                 //number input from the keyboard

if ((day>0) & (day<8))                                                   //check whether a number is in the range from 1 to 7 inclusive
{                                                                        //then there are conditions for each day of the week
  if (day == 1)
  {
    Console.WriteLine("Monday");
  }
  if (day == 2)
  {
    Console.WriteLine("Tuesday");
  }
  if (day == 3)
  {
    Console.WriteLine("Wednesday");
  }
  if (day == 4)
  {
    Console.WriteLine("Thursday");
  }
  if (day == 5)
  {
    Console.WriteLine("Friday! Yep!");
  }
  if (day == 6)
  {
    Console.WriteLine("Saturday! Yep!");
  }
  if (day == 7)
  {
    Console.WriteLine("Sunday( I have to go to work tomorrow(");
  }
}
else
{
    Console.WriteLine("Invalid day of the week");                    //if the number is less than 1 or greater than 7, then display a messageif the number is less than 1 or greater than 7, then display a message
}