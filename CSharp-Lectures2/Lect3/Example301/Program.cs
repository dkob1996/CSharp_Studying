// № 1 - A method that takes nothing and returns nothing.

/*
void Method1()
{
    Console.WriteLine("Author dkob1996");
}

Method1();                                    //method call #1

*/

// № 2 - A method that accepts and returns nothing.

/*

void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2("Text of the message");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "Text of the message", count: 4);
Method21(count: 4, msg: "Text of the message");        //With named variables, you can arrange them however you like.

*/

// № 3 - A method that takes nothing and returns.

/*

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

*/

// № 4 - A method that accepts and returns. (with while cycle)

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

// № 4 - A method that accepts and returns. (with for cycle)

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