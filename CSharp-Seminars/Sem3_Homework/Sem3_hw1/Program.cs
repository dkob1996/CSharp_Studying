//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите пятизначное число");

int numbers = int.Parse(Console.ReadLine());         //Вводим число с клавиатуры

if (numbers >= 10000 && numbers < 100000)            //Проверка на то что число пятизначное
{
    string str = numbers.ToString();                 //Блок преобразования введенного числа в массив "arr"
    int[] arr = new int[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        arr[i] = int.Parse(str[i].ToString());

    }

    int[] mass2 = new int[str.Length];               //Задаем новый массив "mass2"
    int j = arr.Length - 1;

    for (int i = 0; i < arr.Length; i++)             //Цикл с перезаписью массива "arr" в "mass2" наоборот
    {
        mass2[j] = arr[i];
        j = j - 1;
    }

    int numbers2 = 0;                               //Преобразования массива "mass2" в число "numbers2"
    for (int i = 0; i < arr.Length; i++)
    {
        numbers2 = 10 * numbers2 + mass2[i];
    }

    if (numbers2 == numbers)                        //Сравниваем введенное число "numbers" и полученное число "numbers2"
    {
        Console.WriteLine("Да! Палиндром!");
    }
    else
    {
        Console.WriteLine("Нет( Не палиндром");
    }
}
else                                                         //ответ если число не пятизначное
{
    Console.WriteLine("Введите только пятизначное число");
}