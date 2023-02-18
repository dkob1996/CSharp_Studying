/*
Task 64: Set the value to N. Write a program that outputs all natural numbers in the range from N to 1. Execute using recursion.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

try
{
    int N = ReadInt("Enter N:");
    int startNumber = 1;
    Console.WriteLine();
    CountOfN(startNumber, N);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

void CountOfN(int startNumber, int N)                          //Method of output of numbers from N to 1
{
    if (startNumber > N)
    {
        return;
    }
    Console.Write($"{N}" + ";" + " ");
    CountOfN(startNumber, N - 1);

}

int ReadInt(string title)                                      //The method of entering numbers from the keyboard
{
    Console.WriteLine(title);

    bool isParsed = int.TryParse(Console.ReadLine(), out int number);

    if (isParsed)
    {
        return number;
    }

    throw new Exception("Incorrect symbols have been entered");
}
