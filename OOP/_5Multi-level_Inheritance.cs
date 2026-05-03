using System;

class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
        Console.WriteLine("Animal constructor");
    }
}

class Dog : Animal
{
    public int Age { get; set; }

    public Dog(string name, int age) : base(name) // base(name) means name ta Animal e pathacche..C++ hbe Animal(name)..
    {
        this.Age = age;
        Console.WriteLine("Dog constructor");
    }
}

class Puppy : Dog
{
    public Puppy(string name, int age) : base(name, age)
    {
        Console.WriteLine("Puppy constructor");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Puppy p = new Puppy("Tommy", 2);

        Console.WriteLine("\n--- Data ---");
        Console.WriteLine("Name: " + p.Name);
        Console.WriteLine("Age: " + p.Age);
    }
}