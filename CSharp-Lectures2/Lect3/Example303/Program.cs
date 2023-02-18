/*
=====
Work with text
  Given text. In the text, all spaces should be replaced with dashes,
  small letters “k” are replaced by large “K”,
  and big “S” with small “s”.
Is the task clear?


Translation:

Работа с текстом
 Дан текст. В тексте нужно все пробелы заменить чёрточками,
 маленькие буквы “к” заменить большими “К”,
 а большие “С” маленькими “с”.
Ясна ли задача?
*/

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"          //I think, - said the prince, smiling, - that, "
+ "ежели бы вас послали вместо нашего милого Винценгероде,"          //+ "if you were sent instead of our dear Winzengerode,"
+ "вы бы взяли приступом согласие прусского короля."                 //+ "you would have stormed the consent of the Prussian king."
+ "Вы так красноречивы. Вы дадите мне чаю?";                         //+ "You are so eloquent. Will you give me some tea?

//string s = "qwerty"
//            012345
//s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result += $"{newValue}";
        else result += $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '-');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);
Console.WriteLine();
