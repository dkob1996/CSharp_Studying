/*
Task 63: set the value to N. Write a program that will output all natural numbers between 1 and N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
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

void CountOfN(int startNumber, int N)                          //method for outputting numbers from startNumber to N
{
    if (startNumber > N)
    {
        return;
    }
    Console.WriteLine(startNumber);
    CountOfN(startNumber+1, N);

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
