Console.WriteLine("Напишите число");
int num = int.Parse(Console.ReadLine());
for (var count = -num; count <= num; count++)
{
        Console.WriteLine(count);
}