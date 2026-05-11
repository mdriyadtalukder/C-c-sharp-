//“High-level modules should not depend on low-level modules. Both should depend on interface.”Classes should depend on:interfaces/abstractions

using System;
//🔴 Bad Example ❌ (Violates DIP)
class Keyboard
{
    public void Type()
    {
        Console.WriteLine("Typing using keyboard");
    }
}

class Computer
{
    private Keyboard keyboard = new Keyboard(); //Computer directly depends on:Keyboard class

    public void Start()
    {
        keyboard.Type();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Computer c = new Computer();

        c.Start();
    }
}

/*
🔹 Good Example ✅ (Follows DIP)
using System;

// Abstraction
interface IKeyboard
{
    void Type();
}

// Low-level module
class WiredKeyboard : IKeyboard
{
    public void Type()
    {
        Console.WriteLine("Typing using wired keyboard");
    }
}

// Another low-level module
class WirelessKeyboard : IKeyboard
{
    public void Type()
    {
        Console.WriteLine("Typing using wireless keyboard");
    }
}

// High-level module
class Computer
{
    private IKeyboard keyboard; //Computer depends on: IKeyboard interface..not on WiredKeyboard or WirelessKeyboard class

    public Computer(IKeyboard keyboard)
    {
        this.keyboard = keyboard;
    }

    public void Start()
    {
        keyboard.Type();
    }
}

class Program
{
    static void Main(string[] args)
    {
        IKeyboard keyboard = new WirelessKeyboard();

        Computer c = new Computer(keyboard);

        c.Start();
    }
}

*/