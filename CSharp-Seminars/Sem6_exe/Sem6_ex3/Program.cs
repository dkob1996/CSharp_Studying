/*
Task 42: Write a program that will convert a decimal number to binary. 
45 -> 101101
3 -> 11
2 -> 10
*/

Console.WriteLine("Enter a number to convert to binary:");
int number = int.Parse(Console.ReadLine());

string number2nd = ConvertTo2nd(number);

Console.WriteLine($"Translation result: {number2nd}");

string ConvertTo2nd(int number)
{
    string str = String.Empty;                                  //Empty string.
    while (number > 0)
    {
        str = number % 2 + str;
        number /= 2;
    }
    return str;
}
