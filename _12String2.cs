using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter first string: ");
        string s1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string s2 = Console.ReadLine();

        // Convert string to char array
        char[] arr1 = s1.ToCharArray();
        char[] arr2 = s2.ToCharArray();

        // Sort both arrays
        Array.Sort(arr1);
        Array.Sort(arr2);

        // Convert back to string
        string sorted1 = new string(arr1);
        string sorted2 = new string(arr2);

        Console.WriteLine("\nSorted strings:");
        Console.WriteLine(sorted1);
        Console.WriteLine(sorted2);

        // Reverse first string
        Array.Reverse(arr1);
        string reversed1 = new string(arr1);

        Console.WriteLine("\nReversed first string:");
        Console.WriteLine(reversed1);

        // Compare original strings
        Console.WriteLine("\nString Comparison:");
        if (s1 == s2)
        {
            Console.WriteLine("Strings are equal (original)");
        }
        else
        {
            Console.WriteLine("Strings are NOT equal (original)");
        }

        // Compare sorted strings (useful for anagram check)
        if (sorted1 == sorted2)
        {
            Console.WriteLine("Strings are ANAGRAMS (after sorting)");
        }
        else
        {
            Console.WriteLine("Strings are NOT anagrams");
        }
    }
}