using System;

public class Student
{
    public string Name;
    public int Age;

    // Clone method
    public Student Clone()
    {
        return (Student)this.MemberwiseClone();
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student();
        s1.Name = "Riyad";
        s1.Age = 23;

        // Create copy using prototype
        Student s2 = s1.Clone();

        s2.Name = "Rahim";

        Console.WriteLine(s1.Name); // Riyad
        Console.WriteLine(s2.Name); // Rahim
    }
}