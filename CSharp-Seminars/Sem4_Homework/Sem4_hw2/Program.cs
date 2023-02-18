//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int number1 = EnterNumber("Введите число: ");


Console.WriteLine(GoToMassive(number1));

int GoToMassive(int number1)
{
    int result =0;
    string str = number1.ToString();
    int[] arr = new int[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        arr[i] = int.Parse(str[i].ToString());
        result = result + arr[i];
    }
    return result;
}

int EnterNumber(string text)
{
    bool isParsed = false;
    int number = 0;

    while (!isParsed)
    {
        Console.Write(text);
        isParsed = int.TryParse(Console.ReadLine(), out number);
    }
    return number;
}
