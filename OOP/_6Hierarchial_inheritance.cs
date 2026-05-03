using System;

class Animal
{
    public string name { get; set; }

    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Barking...");
    }
}

class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("Meowing...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog d = new Dog();
        Cat c = new Cat();

        d.name = "dggy";
        d.Eat();
        d.Bark();
        Console.WriteLine(d.name);

        
        c.name = "catty";
        c.Eat();
        c.Meow();
        Console.WriteLine(c.name);

    }
}