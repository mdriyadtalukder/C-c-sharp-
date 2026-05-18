//“Clients should not be forced to implement interfaces they do not use.”

using System;
//🔴 Bad Example ❌ (Violates ISP)
interface IWorker
{
    void Work();
    void Eat();
}

class Robot : IWorker
{
    public void Work()
    {
        Console.WriteLine("Robot working");
    }

    // ❌ Robot does not eat
    public void Eat()
    {
        throw new NotImplementedException();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Robot r = new Robot();

        r.Work();
    }
}

/*
🔹 Good Example ✅ (Follows ISP)

using System;

// Small interface 1
interface IWork
{
    void Work();
}

// Small interface 2
interface IEat
{
    void Eat();
}

class Human : IWork, IEat
{
    public void Work()
    {
        Console.WriteLine("Human working");
    }

    public void Eat()
    {
        Console.WriteLine("Human eating");
    }
}

class Robot : IWork
{
    public void Work()
    {
        Console.WriteLine("Robot working");
    }
    //public void Eat(){} //jdi IWork e Eat thakto tahole eivbe rekhe dilei hbe..but eita krbo na..eita value na..coz ei interface ta SRP violate krbe and ei class ta ISP violate krbe.
    }

class Program
{
    static void Main(string[] args)
    {
        Human h = new Human();
        h.Work();
        h.Eat();

        Robot r = new Robot();
        r.Work();
    }
}
*/