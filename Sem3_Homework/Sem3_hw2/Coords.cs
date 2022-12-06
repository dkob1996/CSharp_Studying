namespace Sem2ex3;

public static class Distance
{
    public static double Sqrt(int xa, int ya, int za, int xb, int yb, int zb)
    {
        double result = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya)+(zb-za)*(zb-za));
        return result;
    }
}
