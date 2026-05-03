using System;
//A -> B
// Parent class
class Animal
{
    public string name;
    
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}

// Child class (single inheritance)
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog d = new Dog();

        d.name = "doggy";
        // Parent method
        d.Eat();

        // Child method
        d.Bark();
        Console.WriteLine(d.name);
    }
}