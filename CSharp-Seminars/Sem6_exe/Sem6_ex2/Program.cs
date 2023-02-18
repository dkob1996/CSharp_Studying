/*
Task 40: Write a program that accepts three numbers as input and checks whether a
triangle with sides of this length can exist.
Triangle inequality theorem: Each side of a triangle is less than the sum of the other two sides.
*/

Console.WriteLine("Enter the length of the three sides of the triangle:");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

bool result = TheoryOfTriangles(a, b, c);

Console.WriteLine(result);

bool TheoryOfTriangles(int a, int b, int c)
{
    if ((a < b + c) && (b < a + c) && (c < a + b))
    {
        return true;
    }
    else
    {
        return false;
    }
}