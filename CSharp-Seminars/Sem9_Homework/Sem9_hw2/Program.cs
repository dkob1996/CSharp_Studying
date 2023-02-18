/*
Task 66: Set the values of M and N. Write a program that finds the sum of natural elements
in the range from M to N. Execute using recursion.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

try
{
    int M = ReadInt("Enter M:");
    int N = ReadInt("Enter N:");
    int tmp = 0;
    Console.WriteLine();
    int Result = GetInDegree(tmp, M, N);
    PrintAnswer(Result, M,N);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

int GetInDegree(int tmp, int M, int N)                           //The method of the sum of natural elements from M to N
{
    if (M > N)
    {
        return tmp;
    }
    else
    {
        tmp += M;
        M++;
    }
    return GetInDegree(tmp, M, N);

}

int ReadInt(string title)                                      //the method of entering numbers from the keyboard
{
    Console.WriteLine(title);

    bool isParsed = int.TryParse(Console.ReadLine(), out int number);

    if (isParsed)
    {
        return number;
    }

    throw new Exception("Incorrect symbols have been entered");
}



void PrintAnswer(int Result, int M, int N)                    //Response output method
{
    Console.WriteLine($"Sum of numbers from [{M}] to [{N}] = {Result}.");
}