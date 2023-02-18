// Demonstration of the solution
// Task 31: Specify an array of 12 elements filled with random
// numbers from the interval [-9, 9]. Find the sum of the negative and
// positive elements of the array.
// For example, in the array [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
// the sum of positive numbers is 29, the sum of negative numbers is -20.


//int[] array = CreateRandomArray(4, -9, 9);
//PrintArray(array, "Random Array");

// 1 Variant
//int sumPositive = GetSumPositiveNumbers(array);
//Console.WriteLine(sumPositive);

//int sumNegative = GetSumNegativeNumbers(array);
//Console.WriteLine(sumNegative);

//2 Variant
/*int[] sumNegativeAndPositive = GetSumPositiveAndSumNagativeNumbers(array);
PrintArray(sumNegativeAndPositive, "Sum Positive and Negative");
int[] GetSumPositiveAndSumNagativeNumbers(int[] array)
{
    int[] sumNegativeAndPositive = new int[2];
    for (var i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            sumNegativeAndPositive[0] += array[i];
        }
        else
        {
            sumNegativeAndPositive[1] += array[i];
        }
    }
    return sumNegativeAndPositive;
}*/

// Variant 3
/*
(int,int) sumPositiveAndNagative = GetSumPositiveAndSumNagativeNumbers(array);
Console.WriteLine(sumPositiveAndNagative.Item1);
Console.WriteLine(sumPositiveAndNagative.Item2);

(int, int) GetSumPositiveAndSumNagativeNumbers(int[] array)
{
    int sumPositive = 0;
    int sumNegative = 0;

    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sumPositive += array[i];
        }
        else
        {
            sumNegative += array[i];
        }
    }

    return ( sumPositive, sumNegative);
}
*/
// 4 Variant (bad)
//string result = GetSumPositiveAndSumNagativeNumbers(array);
//Console.WriteLine(result);

/*string GetSumPositiveAndSumNagativeNumbers(int[] array)
{
    int sumPositive = 0;
    int sumNegative = 0;
    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sumPositive += array[i];
        }
        else
        {
            sumNegative += array[i];
        }
    }
    return $"{sumPositive}, {sumNegative}";
}*/


/*
int GetSumPositiveNumbers(int[] array)
{
    int sum = 0;

    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum += array[i];
        }
    }

    return sum;
}


int GetSumNegativeNumbers(int[] array)
{
    int sum = 0;

    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sum += array[i];
        }
    }

    return sum;
}




int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    Random random = new Random();
    int[] array = new int[size];

    for (var i = 0; i < size; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }

    return array;
}

void PrintArray(int[] array, string message)
{
    string str = string.Join(", ", array);
    Console.WriteLine($"{message} - [ {str} ]");
}

*/