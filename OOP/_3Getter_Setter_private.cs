using System;

class Student
{
    private string name;
    private int roll;

    // SetName
    public void SetName(string n)
    {
        name = n;
    }

    // GetName
    public string GetName()
    {
        return name;
    }

    // SetRoll
    public void SetRoll(int r)
    {
        roll = r;
    }

    // GetRoll
    public int GetRoll()
    {
        return roll;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s = new Student();

        s.SetName("Riyad");
        s.SetRoll(101);

        Console.WriteLine("Name: " + s.GetName());
        Console.WriteLine("Roll: " + s.GetRoll());
    }
}