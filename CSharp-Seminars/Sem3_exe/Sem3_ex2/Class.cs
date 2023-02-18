namespace Sem3ex1;

public static class SystemCoordinate
{
    public static string GetNumberOfQuarter(int n)
    {
        if (n == 1)
        {
            return ("x > 0 && y > 0");
        }
        if (n == 2)
        {
            return ("x <0 && y >0");
        }
        if (n == 3)
        {
            return ("x <0 && y< 0");
        }
        if (n == 4)
        {
            return ("x>0 && y<0");
        }
        return "-1";  
    }
}
