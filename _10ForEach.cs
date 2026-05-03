using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 10, 20, 30, 40, 50 };

        Console.WriteLine("Array elements:");

        foreach (int x in arr)
        {
            Console.WriteLine(x);
        }
    }
}