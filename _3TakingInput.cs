using System;

class Program
{
    static void Main(String[] args)
    {
        // string
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        // int
        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());

        // double
        Console.Write("Enter height: ");
        double height = double.Parse(Console.ReadLine());

        // float
        Console.Write("Enter weight: ");
        float weight = float.Parse(Console.ReadLine());

        // char
        Console.Write("Enter grade: ");
        char grade = Console.ReadLine()[0];

        // bool
        Console.Write("Are you a student (true/false): ");
        bool isStudent = bool.Parse(Console.ReadLine());

        // decimal
        Console.Write("Enter salary: ");
        decimal salary = decimal.Parse(Console.ReadLine());

        Console.WriteLine("\n--- Output ---");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Height: " + height);
        Console.WriteLine("Weight: " + weight);
        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("Student: " + isStudent);
        Console.WriteLine("Salary: " + salary);
    }
}