using System;

class MathOps
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}

class Program
{
    static void Main(string[] args)
    {
        MathOps m = new MathOps();

        Console.WriteLine(m.Add(2, 3));
        Console.WriteLine(m.Add(2, 3, 4));
    }
}