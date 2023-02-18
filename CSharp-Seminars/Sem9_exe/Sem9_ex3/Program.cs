/*
Task 67: Write a program that will accept a number as input and return the sum of its digits.
453 -> 12 45 -> 9
*/


try
{
    int N = ReadInt("Enter number:");
    Console.WriteLine();
    int Result = 0;
    int Sum = SumOfNumbers(Result, N);
    PrintAnswer(Sum);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

int SumOfNumbers(int Result, int N)                                    //Method of returning the sum of digits of a number
{
    if (N <= 0)
    {
        return Result;
    }
    else
    {
    Result += N % 10;
    N /= 10;
    }
    return SumOfNumbers(Result, N);

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


void PrintAnswer(int Sum)
{
    Console.WriteLine(Sum);
}