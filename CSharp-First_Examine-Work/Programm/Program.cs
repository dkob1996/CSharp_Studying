/*Write a program that, from an existing array of strings, forms an array of strings whose length is
less than or equal to 3 characters. 

The primary array can be entered from the keyboard, or set at the start of the algorithm execution.
When solving, it is not recommended to use collections, it is better to do exclusively with arrays.
*/

/*
Text string:
1,count,string,12,ot,=@,5,123313,3
*/



Console.WriteLine("Enter an array of comma-delimited strings ',':");                      //Comments on keyboard input
string m = Console.ReadLine();                                                                     //Entering the initial line from the keyboard
//Console.WriteLine($"The entered string: {m}");                                                     //Test intermediate line

int LengthOfMassive = CountOfMassiveLength(m);                                                     //Storing the length of the future array
//Console.WriteLine($"Number of array elements: {LengthOfMassive}");                           //Test intermediate line

(string[], int[]) ArrayAndCount = CreateStringArray(m, LengthOfMassive);                           //A caravan of two arrays - string separated by elements, and the number of elements in each element of the string

Console.WriteLine();
Console.WriteLine("The entered array of strings:");                                                      //Comment on the output of the initial array of strings
PrintStringArray(ArrayAndCount.Item1);                                                             //Output of the initial array of strings

//Console.WriteLine("Array of the number of elements:");                                               //Test intermediate line - comment on the output of the number of elements in each element of the string
//PrintElementsArray(ArrayAndCount.Item2);                                                         //Output of the number of elements in each element of the string (optional, for verification)


int ValueOfNeededSymbols = 3;                                                                      //Entering the number of characters to limit when sorting the original array of strings (you can always change to another number)
int count = CountOfElementsInMassive(ArrayAndCount.Item2, ValueOfNeededSymbols);                   //Storing information to allocate space for the final array of strings
//Console.WriteLine($"The number of elements is greater {ValueOfNeededSymbols}: {count}");               //Test intermediate line

string[] FinalMassive = CreateFinalMassive(ArrayAndCount, count, ValueOfNeededSymbols);            //Method for creating the final array of strings

Console.WriteLine();
Console.WriteLine($"Array of strings with elements <= {ValueOfNeededSymbols}:");                        //Comment on the output of an array with certain elements
PrintStringArray(FinalMassive);                                                                    //Output of the final array of strings



int CountOfMassiveLength(string m)                                                                   //A method that calculates how long the future array of strings should be
{
    int tmp = 1;
    char result = ',';
    for (int i = 0; i < m.Length; i++)
    {
        if (m[i] == result) tmp++;
    }
    return tmp;
}

(string[], int[]) CreateStringArray(string m, int LengthOfMassive)                                   //A method that splits a string into an array of strings, and creates an array of the number of elements in each row of a new array
{
    char tmp = ',';
    int[] count = new int[LengthOfMassive];
    string[] array = new string[LengthOfMassive];
    for (int i = 0, k = 0; i < m.Length; i++)
    {
        if (m[i] != tmp)
        {
            array[k] += $"{m[i]}";
            count[k]++;
        }
        else k++;
    }
    return (array, count);
}

void PrintStringArray(string[] array)                                                                //Method of printing the string array
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {

        Console.Write($"{array[i]},");
    }
    Console.Write(array[array.Length - 1]);
    Console.WriteLine("]");
}

/*
void PrintElementsArray(int[] array)                                                                 //Int array printing method (optional, made for verification)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {

        Console.Write($"{array[i]},");
    }
    Console.Write(array[array.Length - 1]);
    Console.WriteLine("]");
}
*/

int CountOfElementsInMassive(int[] array, int ValueOfNeededSymbols)                                  //Method of searching for the number of elements greater than the required value for allocating memory to a new array
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= ValueOfNeededSymbols) count++;
    }
    return count;
}

string[] CreateFinalMassive((string[], int[]) ArrayAndCount, int count, int ValueOfNeededSymbols)    //The method of creating a new array with the elements we need in length
{
    string[] massive = new string[count];
    for (int i = 0, k = 0; i < ArrayAndCount.Item1.Length; i++)
    {
        if (ArrayAndCount.Item2[i] <= ValueOfNeededSymbols)
        {
            massive[k] = ArrayAndCount.Item1[i]; k++;
        }
    }
    return massive;
}