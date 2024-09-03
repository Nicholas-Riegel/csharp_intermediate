namespace basics_01;

public class MethodOverload
{
    public static double GetSum(double x, double y)
    {
        return x + y;
    }

    public static double GetSum(string x, string y)
    {
        double dblx = Convert.ToDouble(x);
        double dbly = Convert.ToDouble(y);
        return dblx + dbly;
    }
}