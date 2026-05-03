using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        int i = 1;

        while (i <= n)
        {
            Console.WriteLine(i);
            i++; // update
        }
    }
}