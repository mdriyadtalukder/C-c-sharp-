/*
Bridge Pattern is a structural design pattern used to separate abstraction from implementation so both can change independently.

Simple definition:

Bridge Pattern separates two related things so they can be changed independently.


Problem First

Suppose you have:

2 types of Remote
Basic Remote
Smart Remote

2 TV brands
Samsung TV
Sony TV

Without Bridge Pattern, you may create:

SamsungBasicRemote
SamsungSmartRemote
SonyBasicRemote
SonySmartRemote

See the problem?

If a new TV brand comes:
LG

Now again:

LGBasicRemote
LGSmartRemote

Too many classes 😵

Bridge Pattern Solution

Instead of combining everything,

We separate them.

Remote side
Basic Remote
Smart Remote
TV side
Samsung TV
Sony TV

Then connect them using a bridge.

Like:

Basic Remote  ─── Samsung TV
Smart Remote  ─── Sony TV

Any remote can work with any TV.


Simple explanation
Remote does NOT inherit TV ❌
Remote uses TV inside it ✅ → HAS-A (Composition)
TV implementations implement interface → IS-A

| Advantages                                                                                          | Disadvantages                                                |
| --------------------------------------------------------------------------------------------------- | ------------------------------------------------------------ |
| Avoids **class explosion** (no need for many combinations like SamsungBasicRemote, SonySmartRemote) | Adds **extra complexity** due to more classes and interfaces |
| Separates **abstraction and implementation** clearly                                                | Increases **indirection** (more layers between objects)      |
| Makes system **easy to extend** (new TV or Remote can be added easily)                              | Not useful for **simple applications**                       |
| Provides **loose coupling** between components                                                      | Harder to understand for beginners                           |
| Follows **Open/Closed Principle**                                                                   | Requires more design effort upfront                          |

*/

using System;

// =====================
// Implementor (TV side)
// =====================
interface ITV
{
    void On();
    void Off();
}

// =====================
// Concrete Implementations
// =====================
class SamsungTV : ITV
{
    public void On()
    {
        Console.WriteLine("Samsung TV is ON");
    }

    public void Off()
    {
        Console.WriteLine("Samsung TV is OFF");
    }
}

class SonyTV : ITV
{
    public void On()
    {
        Console.WriteLine("Sony TV is ON");
    }

    public void Off()
    {
        Console.WriteLine("Sony TV is OFF");
    }
}

// =====================
// Abstraction (basic remote)
// =====================
class Remote
{
    protected ITV tv; //has a relation

    public Remote(ITV tv)
    {
        this.tv = tv;
    }

    public void TurnOn()
    {
        tv.On();
    }

    public void TurnOff()
    {
        tv.Off();
    }
}

// =====================
// Refined Abstraction (smart remote)
// =====================
class AdvancedRemote : Remote
{
    public AdvancedRemote(ITV tv) : base(tv)
    {
    }

    public void Mute()
    {
        Console.WriteLine("TV is muted");
    }
}

// =====================
// Client Code
// =====================
class Program
{
    static void Main()
    {
        // Using Samsung TV with basic remote
        Remote remote1 = new Remote(new SamsungTV());
        remote1.TurnOn();
        remote1.TurnOff();

        Console.WriteLine();

        // Using Sony TV with advanced remote
        AdvancedRemote remote2 = new AdvancedRemote(new SonyTV());
        remote2.TurnOn();
        remote2.Mute();
        remote2.TurnOff();
    }
}

/*
is a relationship--inheritance
class Animal
{
    public void Eat() { }
}

class Dog : Animal   // Dog IS-A Animal
{
    public void Bark() { }
}

*/
/*
has a relationship--composition
class Engine
{
    public void Start() { }
}

class Car
{
    private Engine engine = new Engine(); // Car HAS-A Engine

    public void Drive()
    {
        engine.Start();
    }
}

*/