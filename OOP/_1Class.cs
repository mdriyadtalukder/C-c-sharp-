using System;
/*
Student → class
s1 → instance (object)----An instance means an object created from a class.
new Student() → creates instance (object)
*/
class Student //In C#, class members are private by default, but the class itself is internal by default. This is different from C++ where class members are also private by default.
              //👉 internal means the member is accessible only within the same project.
{
    // Fields (variables)
    public string name; 
    public int age;

    // Method (function)
    public void Display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create object
        Student s1 = new Student();

        // Assign values
        s1.name = "Riyad";
        s1.age = 22;

        // Call method
        s1.Display();
    }
}