/*Don’t add features, classes, methods, or complexity
unless they are actually needed now.*/
using System;

//🔹 Bad OOP Design ❌ (Violates YAGNI)
class Animal
{
    public string Name { get; set; }

    // Not needed now ❌
    public void Fly()
    {
        Console.WriteLine("Animal can fly");
    }

    // Not needed now ❌
    public void Swim()
    {
        Console.WriteLine("Animal can swim");
    }

    // Only this is needed now
    public void Eat()
    {
        Console.WriteLine(Name + " is eating");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal a = new Animal();
        a.Name = "Dog";
        a.Eat();
    }
}

/*
🔹 Good OOP Design ✅ (Follows YAGNI)

using System;

class Animal
{
    public string Name { get; set; }

    public void Eat()
    {
        Console.WriteLine(Name + " is eating");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal a = new Animal();

        a.Name = "Dog";

        a.Eat();
    }
}

*/