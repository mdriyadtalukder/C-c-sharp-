using System;

class Program
{
    static void Main(String[] args)
    {
        Console.Write("Enter a number: ");
        int num;
        //int num = int.Parse(Console.ReadLine()); //If input is invalid (e.g., "abc"), it throws an exception (crash) ❌


        if (int.TryParse(Console.ReadLine(), out num)) //If fails, no crash ✅..Returns false if invalid
        {
            if (num > 0)
                Console.WriteLine("Positive");
            else if (num < 0)
                Console.WriteLine("Negative");
            else
                Console.WriteLine("Zero");
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}