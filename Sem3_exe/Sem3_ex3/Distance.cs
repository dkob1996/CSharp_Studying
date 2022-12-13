namespace Sem2ex3;

public static class Distance
{
    public static double Sqrt(int xa, int ya, int xb, int yb)
    {
        double result = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya));
        return result;
    }
}
