Console.Write("Enter name of user:");
string username = Console.ReadLine();

if (username.ToLower() == "Masha")
{
   Console.WriteLine("Yep, this is Masha");
}
else
{
    Console.Write("Hello,");
    Console.WriteLine(username);
}
