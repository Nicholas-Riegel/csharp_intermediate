namespace delegates_08;

class Program
{
    static void Main(string[] args)
    {
        Arithmetic add, sub, addSub;
        add = new Arithmetic(Add);
        sub = new Arithmetic(Subtract);
        addSub = add + sub;

        add(6, 10);
        addSub(10, 4);
    }

    public delegate void Arithmetic(double num1, double num2);

    public static void Add(double num1, double num2)
    {
        Console.WriteLine($"{num1} + {num2} = {num1 + num2}.");
    }
    
    public static void Subtract(double num1, double num2)
    {
        Console.WriteLine($"{num1} - {num2} = {num1 - num2}.");
    }
}
