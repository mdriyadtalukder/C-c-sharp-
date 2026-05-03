using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter size of array: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        // Taking input
        Console.WriteLine("Enter " + n + " elements:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        // Sorting array
        Array.Sort(arr);
        //Reverse Array
        Array.Reverse(arr);


        // Printing input array
        Console.WriteLine("Input array:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(arr[i]);
        }



        // Fixed array
        int[] ar = { 1, 2, 3, 4 };
        // Printing fixed array
        Console.WriteLine("Fixed array:");
        for (int i = 0; i < ar.Length; i++)
        {
            Console.WriteLine(ar[i]);
        }
    }
}