/*
Task 69: Write a program that takes two numbers A and B as input, and raises the number A to the integer power of B using recursion.
A = 3; B = 5 -> 243 (35) A = 2; B = 3 -> 8
*/


try
{
    int A = ReadInt("Enter A:");
    int B = ReadInt("Enter B:");
    int tmp = 1;
    Console.WriteLine();
    int Result = GetInDegree(tmp, A, B);
    PrintAnswer(Result, A,B);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

int GetInDegree(int tmp, int A, int B)                                    //The method of exponentiation
{
    if (B == 0)
    {
        return tmp;
    }
    else
    {
        tmp *= A;
        B--;
    }
    return GetInDegree(tmp, A, B);

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


void PrintAnswer(int Result, int A, int B)                    //Response output method
{
    Console.WriteLine($"[{A}] to the degree of [{B}] = {Result}.");
}