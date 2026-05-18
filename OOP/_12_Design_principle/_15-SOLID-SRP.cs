/*
👉 SRP is the first principle of SOLID.
“A class should have only one reason to change.”
👉 One class = one responsibility/job only.
*/

using System;
//🔹 Bad Example ❌ (Violates SRP)
class Student
{
    public string Name { get; set; }

    // Student data
    public void GetStudentInfo()
    {
        Console.WriteLine("Student: " + Name);
    }

    // Database logic ❌
    public void SaveToDatabase()
    {
        Console.WriteLine("Saving student to database");
    }

    // Email logic ❌
    public void SendEmail()
    {
        Console.WriteLine("Sending email");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s = new Student();

        s.Name = "Riyad";

        s.GetStudentInfo();
        s.SaveToDatabase();
        s.SendEmail();
    }
}

/*
🔹 Good Example ✅ (Follows SRP)
using System;

class Student
{
    public string Name { get; set; }

    public void GetStudentInfo()
    {
        Console.WriteLine("Student: " + Name);
    }
}

// Separate responsibility
class StudentRepository
{
    public void SaveToDatabase()
    {
        Console.WriteLine("Saving student to database");
    }
}

// Separate responsibility
class EmailService
{
    public void SendEmail()
    {
        Console.WriteLine("Sending email");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s = new Student();
        s.Name = "Riyad";

        StudentRepository repo = new StudentRepository();
        EmailService email = new EmailService();

        s.GetStudentInfo();
        repo.SaveToDatabase();
        email.SendEmail();
    }
}

*/