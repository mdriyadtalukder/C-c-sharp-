using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter columns: ");
        int cols = int.Parse(Console.ReadLine());

        string[,] grid = new string[rows, cols];

        // Taking input
        Console.WriteLine("Enter string values:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                grid[i, j] = Console.ReadLine();
            }
        }

        // Printing grid
        Console.WriteLine("2D String Grid:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(grid[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}