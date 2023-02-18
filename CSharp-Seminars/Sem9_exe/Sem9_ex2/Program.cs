/*
Task 65: set the values M and N. Write a program that will output all natural numbers between M and N.
M = 1; N = 5 -> "1, 2, 3, 4, 5" M = 4; N = 8 -> "4, 6, 7, 8"
*/

try
{
    int M = ReadInt("Enter M:");
    int N = ReadInt("Enter N:");
    Console.WriteLine();
    if (M >= N)
    {
        Console.WriteLine($"The number M=[{M}] must be less than N=[{N}]");
    }
    else
    {
        CountOfN(M, N);
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

void CountOfN(int M, int N)                                    //Method of output of numbers from M to N
{
    if (M > N)
    {
        return;
    }
    Console.WriteLine(M);
    CountOfN(M + 1, N);

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
