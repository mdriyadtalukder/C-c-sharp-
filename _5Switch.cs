using System;

class Program
{
    static void Main(String[] args)
    {
        Console.Write("Enter a number (1-3): ");
        int num = int.Parse(Console.ReadLine());

        switch (num)
        {
            case 1:
                Console.WriteLine("One");
                break;

            case 2:
                Console.WriteLine("Two");
                break;

            case 3:
                Console.WriteLine("Three");
                break;

            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }
}