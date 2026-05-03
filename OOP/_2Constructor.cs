using System;

class Student
{
    public string name;
    public int age;

    // 1️⃣ Non-parameterized constructor
    public Student()
    {
        name = "Default";
        age = 0;
    }

    // 2️⃣ Parameterized constructor
    public Student(string name, int age)
    {
        //this
        this.name = name; //name ta parameter and this.name mane ei object er name ta.
        this.age = age; ////age ta parameter and this.age mane ei object er age ta.
    }

    // 3️⃣ Copy constructor
    public Student(Student s)
    {
        name = s.name;
        age = s.age;
    }

    public void Display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Non-parameterized
        Student s2 = new Student();
        Console.WriteLine("Non-parameterized:");
        s2.Display();

        // Parameterized
        Student s3 = new Student("Riyad", 22);
        Console.WriteLine("Parameterized:");
        s3.Display();

        // Copy constructor
        Student s4 = new Student(s3);
        Console.WriteLine("Copy constructor:");
        s4.Display();
    }
}