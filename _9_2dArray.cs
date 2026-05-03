using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter columns: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] arr = new int[rows, cols];

        // Taking input
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                arr[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Printing matrix
        Console.WriteLine("Matrix is:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }

        //fixed 2d

        int[,] ar =
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.WriteLine("Matrix is:");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(ar[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}