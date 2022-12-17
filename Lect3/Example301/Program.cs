// № 1 - Метод который ничего не принимает и ничего не возвращает.

/*
void Method1()
{
    Console.WriteLine("Автор dkob1996");
}

Method1();                                    //вызов метода №1

*/

// № 2 - Метод который принимает и ничего не возвращает.

/*

void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2("Такст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "Такст сообщения", count: 4);
Method21(count: 4, msg: "Такст сообщения");        //можно при именованных переменных располагать их как угодно.

*/

// № 3 - Метод который ничего не принимает и возвращает.

/*

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

*/

// № 4 - Метод который принимает и возвращает. (c циклом while)

/*

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result += text;
        i++;
    }
    return result;
}

string res = Method4(10, "f");
Console.WriteLine(res);

*/

// № 4 - Метод который принимает и возвращает. (c циклом for)

/*

string Method4(int count, string text)
{

    string result = String.Empty;

    for (int i = 0; i < count; i++)
    {
        result += text;
    }
    return result;
}

string res = Method4(10, "f");
Console.WriteLine(res);

*/