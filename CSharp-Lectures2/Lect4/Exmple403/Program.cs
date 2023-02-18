//Факториал

double Factorial(int N)
{
    //1! = 1.
    //0! = 1.
    if (N == 1) return 1;
    else return N * Factorial(N - 1);
}

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}!={Factorial(i)}");
}