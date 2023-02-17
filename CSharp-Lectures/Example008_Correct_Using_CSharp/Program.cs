using System.Linq;

string text = "(1,2) (2,3) (3,4) (4,5) (5,6) (6,7)"
              .Replace("(", "")
              .Replace(")", "")
              ;
Console.WriteLine(text);
var data = text.Split(" ")
               .Select(item => item.Split(','))
               .Select(coord => (x: int.Parse(coord[0]), y: int.Parse(coord[1])))
               .Where(coord => coord.x % 2 == 0)
               .Select(point => (point.x * 10, point.y))
               .ToArray();


for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
    //Console.WriteLine(data[i].x * 10);
    /*
    for (int k = 0; k < data[i].Length; k++)
    {
        Console.WriteLine(data[i][k]);
    }
    */
    //Console.WriteLine();
}