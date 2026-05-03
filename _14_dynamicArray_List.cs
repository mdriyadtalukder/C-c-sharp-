using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create list
        List<int> list = new List<int>();

        // Add elements
        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.Add(40);

        Console.WriteLine("Original List:");
        foreach (int x in list)
        {
            Console.WriteLine(x);
        }

        // Insert at index
        list.Insert(1, 99);

        Console.WriteLine("\nAfter Insert:");
        foreach (int x in list)
        {
            Console.WriteLine(x);
        }

        // Remove element
        list.Remove(30);

        Console.WriteLine("\nAfter Remove:");
        foreach (int x in list)
        {
            Console.WriteLine(x);
        }

        // Check contains
        Console.WriteLine("\nContains 20? " + list.Contains(20));

        // Count
        Console.WriteLine("Count: " + list.Count);

        // IndexOf
        Console.WriteLine("Index of 99: " + list.IndexOf(99));

        // Sort
        list.Sort();

        Console.WriteLine("\nAfter Sort:");
        foreach (int x in list)
        {
            Console.WriteLine(x);
        }

        // Reverse
        list.Reverse();

        Console.WriteLine("\nAfter Reverse:");
        foreach (int x in list)
        {
            Console.WriteLine(x);
        }

        // Clear
        list.Clear();

        Console.WriteLine("\nAfter Clear, Count: " + list.Count);
    }
}