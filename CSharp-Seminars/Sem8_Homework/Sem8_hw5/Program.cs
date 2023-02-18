/*
Task 62. Write a program that will fill a 4-by-4 spiral array.
For example, the output is an array like this:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

try
{
    int m = ReadInt("Enter the number of columns:");
    int n = ReadInt("Enter the number of lines:");

    Console.WriteLine();
    int[,] array = new int[m, n];
    Create2DSpiralArray(array);
    Console.WriteLine("Spiral Array:");
    Print2DArray(array);
    Console.WriteLine();

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

void Print2DArray(int[,] array)                         //Two-dimensional array printing method
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void Create2DSpiralArray(int[,] array)                  //Method of filling a spiral two-dimensional array
{
    int hight = array.GetLength(0);
    int width = array.GetLength(1);

    int s = 1; 
                                            
    for (int y = 0; y < width; y++)                      //Filling in the first perimeter
    {
        array[0, y] = s;
        s++;
    }
    for (int x = 1; x < hight; x++)
    {
        array[x, width - 1] = s;
        s++;
    }
    for (int y = width - 2; y >= 0; y--)
    {
        array[hight - 1, y] = s;
        s++;
    }
    for (int x = hight - 2; x > 0; x--)
    {
        array[x, 0] = s;
        s++;
    }

    int c = 1;                                   //initialize the initial coordinates of the second circle
    int d = 1;

    while (s < hight * width)
    {
        while (array[c, d + 1] == 0)             //to the right
        {
            array[c, d] = s;
            s++;
            d++;
        }

        while (array[c + 1, d] == 0)            //down
        {
            array[c, d] = s;
            s++;
            c++;
        }

        while (array[c, d - 1] == 0)            //left
        {
            array[c, d] = s;
            s++;
            d--;
        }

        while (array[c - 1, d] == 0)            //up
        {
            array[c, d] = s;
            s++;
            c--;
        }
    }

    for (int x = 0; x < hight; x++)            //fill in the last value in the center
    {
        for (int y = 0; y < width; y++)
        {
            if (array[x, y] == 0)
            {
                array[x, y] = s;
            }
        }
    }
}

int ReadInt(string title)                               //The method of entering numbers from the keyboard
{
    Console.WriteLine(title);

    bool isParsed = int.TryParse(Console.ReadLine(), out int number);

    if (isParsed)
    {
        return number;
    }

    throw new Exception("Incorrect symbols have been entered");
}
