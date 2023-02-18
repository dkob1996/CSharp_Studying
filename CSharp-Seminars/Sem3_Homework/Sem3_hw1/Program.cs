//Task 19
//Write a program that accepts a five-digit number as input and checks whether it is a palindrome.
//14212 -> no
//12821 -> yes
//23432 -> yes

Console.WriteLine("Enter a five-digit number");

int numbers = int.Parse(Console.ReadLine());         //Enter a number from the keyboard

if (numbers >= 10000 && numbers < 100000)            //Checking that the number is five-digit
{
    string str = numbers.ToString();                 //The block for converting the entered number into an array "arr"
    int[] arr = new int[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        arr[i] = int.Parse(str[i].ToString());

    }

    int[] mass2 = new int[str.Length];               //Setting a new array "mass2"
    int j = arr.Length - 1;

    for (int i = 0; i < arr.Length; i++)             //A loop with overwriting the array "arr" in "mass2" vice versa
    {
        mass2[j] = arr[i];
        j = j - 1;
    }

    int numbers2 = 0;                               //Converting the array "mass2" to the number "numbers 2"
    for (int i = 0; i < arr.Length; i++)
    {
        numbers2 = 10 * numbers2 + mass2[i];
    }

    if (numbers2 == numbers)                        //Compare the entered number "numbers" and the resulting number "numbers 2"
    {
        Console.WriteLine("Yes! Palindrome!");
    }
    else
    {
        Console.WriteLine("No (Not a palindrome");
    }
}
else                                                         //answer if the number is not five-digit
{
    Console.WriteLine("Enter only a five-digit number");
}