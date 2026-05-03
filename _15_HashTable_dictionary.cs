using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create dictionary
        Dictionary<string, int> dict = new Dictionary<string, int>();

        // Add elements
        dict.Add("Riyad", 22);
        dict.Add("Alex", 25);
        dict.Add("John", 30);

        Console.WriteLine("Dictionary elements:");

        foreach (var item in dict)
        {
            Console.WriteLine(item.Key + " => " + item.Value);
        }

        // Access value using key
        Console.WriteLine("\nAge of Alex: " + dict["Alex"]);

        // Check key exists
        Console.WriteLine("Contains Riyad? " + dict.ContainsKey("Riyad"));

        // Remove element
        dict.Remove("John");

        Console.WriteLine("\nAfter Remove:");

        foreach (var item in dict)
        {
            Console.WriteLine(item.Key + " => " + item.Value);
        }

        // Count
        Console.WriteLine("\nCount: " + dict.Count);

        // TryGetValue (safe access)
        int age;
        if (dict.TryGetValue("Riyad", out age))
        {
            Console.WriteLine("Riyad's age: " + age);
        }
    }
}