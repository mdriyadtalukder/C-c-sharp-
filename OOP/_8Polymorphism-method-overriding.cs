using System;

class Animal
{
    public virtual void Sound() //virtual means future e override krte hbe..
    {
        Console.WriteLine("Animal sound");
    }
}

class Dog : Animal
{
    public override void Sound() //future e override kra holo..
    {
        Console.WriteLine("Dog barks");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal a = new Dog(); // parent reference, child object

        a.Sound(); // runtime decision
    }
}