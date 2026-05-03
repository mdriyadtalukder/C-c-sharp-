using System;

class Student
{
    private int roll;

    public string Name { get; set; }

    public int Roll
    {
        get { return roll; }
        set
        {
            if (value > 0)
                roll = value;
            else
                Console.WriteLine("Invalid roll!");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s = new Student();

        s.Name = "Riyad";
        s.Roll = -5;   // invalid
        s.Roll = 101;  // valid

        Console.WriteLine("Name: " + s.Name);
        Console.WriteLine("Roll: " + s.Roll);
    }
}