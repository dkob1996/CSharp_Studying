/*
Task 43: Write a program that finds the intersection point of two straight
lines given by the equations y = k1 * x + b1, y = k2 * x + b2; 
the values b1, k1, b2 and k2 are set by the user.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> 
(-0,5; -0,5)

b1 = 2, k1 = 5, b2 = 4, k2 = 5 
Parallel

b1 = 2, k1 = 5, b2 = 2, k2 = 5 
Match
*/

double b1 = EnterNumber("Enter number b1: ");                                                  //entering variables from the keyboard
double k1 = EnterNumber("Enter number k1: ");
double b2 = EnterNumber("Enter number b2: ");
double k2 = EnterNumber("Enter number k2: ");

(double, double, bool, bool) FindComasOfCrossroad(double b1, double k1, double b2, double k2)   //method for finding intersections
{
    double findX = 0;
    double findY = 0;
    bool cross = true;
    bool parallel = false;

    if (k1 != k2)
    {
        findX = (b2 - b1) / (k1 - k2);
        findY = (b1 * k2 - b2 * k1) / (k2 - k1);
        cross = true;
    }
    if ((k1 == k2) && (b1 != b2))
    {
        cross = false;
    }
    if ((k1 == k2) && (b1 == b2))
    {
        parallel = true;
    }
    return (findX, findY, cross, parallel);

}

(double, double, bool, bool) CoordsAndFlags = FindComasOfCrossroad(b1, k1, b2, k2);                   //reference to the method for finding intersections


PrintAnswer(CoordsAndFlags);                                                                         //accessing the method to output x,y, or another response


void PrintAnswer((double, double, bool, bool) CoordsAndFlags)                                        //message output method
{
    if ((CoordsAndFlags.Item3 == true) && (CoordsAndFlags.Item4 == false))
    {
        Console.WriteLine($"Intersection coordinates - x: {CoordsAndFlags.Item1}, y: {CoordsAndFlags.Item2}");
    }
    if (CoordsAndFlags.Item4 == true)
    {
        Console.WriteLine("Straight lines match");
    }
    if (CoordsAndFlags.Item3 == false)
    {
        Console.WriteLine("Straight lines are parallel");
    }
}


double EnterNumber(string text)                                                                         //method of printing a message when entering variables
{
    bool isParsed = false;
    double number = 0;

    while (!isParsed)
    {
        Console.Write(text);
        isParsed = double.TryParse(Console.ReadLine(), out number);
    }
    return number;
}