namespace oop.Classes;

public class ShapeMath
{
    public static double GetArea(string shape = "", double length1 = 0, double length2 = 0)
    {
        if (string.Equals("rectangle", shape, StringComparison.OrdinalIgnoreCase))
        {
            return length1 * length2;
        }
        else if (string.Equals("triangle", shape, StringComparison.OrdinalIgnoreCase))
        {
            return length1 * length2 / 2;
        }
        else if (string.Equals("circl", shape, StringComparison.OrdinalIgnoreCase))
        {
            return Math.PI * Math.Pow(length1, 2);
        }
        else
        {
            return -1;
        }
    }
}
