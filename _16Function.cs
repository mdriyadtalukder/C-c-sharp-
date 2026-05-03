using System;

class Program
{
    static void SayHello()
    {
        Console.WriteLine("Hello, World!");
    }
    static int Multiply(int a, int b)
    {
        return a * b;
    }
    static void Main(string[] args)
    {
        SayHello();
        int result = Multiply(5, 4);
        Console.WriteLine("Result = " + result);

    }


}