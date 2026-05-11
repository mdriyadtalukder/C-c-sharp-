/*
👉 If child class inherits parent class,then child should behave properly as parent.Child should not break parent behavior.

*/

using System;
//🔴 Bad Example ❌ (Violates LSP)
interface IFlyable
{
    void Fly();
}

class Sparrow : IFlyable
{
    public void Fly()
    {
        Console.WriteLine("Sparrow flies");
    }
}

// ❌ Bad design
/*
Why BAD?

Because:

IFlyable means:
'I can fly'

But:

Ostrich cannot fly

👉 So substitution breaks.parent fly kre but child kre na..parent er behavior follow kre nai
*/
class Ostrich : IFlyable
{
    public void Fly()
    {
        throw new Exception("Ostrich cannot fly");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IFlyable bird = new Ostrich();

        bird.Fly(); // ❌ Runtime error
    }
}

/*
🔹 Good Example ✅ (Follows LSP)
using System;

interface IFlyable
{
    void Fly();
}

interface IRunable
{
    void Run();
}

// ✔ Correct
class Sparrow : IFlyable
{
    public void Fly()
    {
        Console.WriteLine("Sparrow flies");
    }
}

// ✔ Correct
class Ostrich : IRunable
{
    public void Run()
    {
        Console.WriteLine("Ostrich runs");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IFlyable bird1 = new Sparrow();
        bird1.Fly();

        IRunable bird2 = new Ostrich();
        bird2.Run();
    }
}

*/