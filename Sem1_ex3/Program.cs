Console.WriteLine("Напишите номер от 1 до 7 включительно");
int day = int.Parse(Console.ReadLine());

if ((day>0) & (day<8))
{
  if (day == 1)
  {
    Console.WriteLine("Понедельник");
  }
  if (day == 2)
  {
    Console.WriteLine("Вторник");
  }
  if (day == 3)
  {
    Console.WriteLine("Среда");
  }
  if (day == 4)
  {
    Console.WriteLine("Четверг");
  }
  if (day == 5)
  {
    Console.WriteLine("Пятница! Ура!");
  }
  if (day == 6)
  {
    Console.WriteLine("Суббота! Ура!");
  }
  if (day == 7)
  {
    Console.WriteLine("Воскресенье( Завтра на работу(");
  }
}
else
{
    Console.WriteLine("Некорректное число дня недели");
}