using System;

class Program
{
    static void Main(string[] args)
    {
        string str = "  Hello World  ";

        Console.WriteLine("Original string: '" + str + "'");

        // Length
        Console.WriteLine("Length: " + str.Length);

        // ToUpper
        Console.WriteLine("Uppercase: " + str.ToUpper());

        // ToLower
        Console.WriteLine("Lowercase: " + str.ToLower());

        // Trim (remove spaces)
        Console.WriteLine("Trim: '" + str.Trim() + "'");

        // Substring
        Console.WriteLine("Substring (0,5): " + str.Trim().Substring(0, 5));

        // Replace
        Console.WriteLine("Replace: " + str.Replace("World", "C#"));

        // Contains
        Console.WriteLine("Contains 'Hello': " + str.Contains("Hello"));

        // IndexOf
        Console.WriteLine("IndexOf 'o': " + str.IndexOf('o'));

        // Split
        string[] words = str.Trim().Split(' ');
        Console.WriteLine("Split words:");
        foreach (string w in words)
        {
            Console.WriteLine(w);
        }
    }
}