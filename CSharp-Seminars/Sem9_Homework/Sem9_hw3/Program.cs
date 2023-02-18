/*
Task 68: Write a program for calculating the Ackerman function using recursion. Two non-negative numbers m and n are given.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/


try
{
    int m = ReadInt("Enter m:");
    int n = ReadInt("Enter n:");
    Console.WriteLine();
    int Result = Akkerman(m, n);
    PrintAnswer(Result, m, n);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

int Akkerman(int m, int n)                           //Ackerman function method
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if ((m != 0) && (n == 0))
        {
            return Akkerman(m - 1, 1);
        }
        else
        {
            return Akkerman(m - 1, Akkerman(m, n - 1));
        }
    }

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



void PrintAnswer(int Result, int m, int n)                    //Response output method
{
    Console.WriteLine($"A(m,n) = A({m},{n}) = {Result}.");
}