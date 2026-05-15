/*
#Abstract Factory creates a group of related objects together.

Real Life Example:

Suppose you are making a Gaming Setup.

There are two brands:

ASUS
MSI

Each brand provides:

Keyboard
Mouse

If user selects ASUS:

ASUS Keyboard
ASUS Mouse

If user selects MSI:

MSI Keyboard
MSI Mouse

The factory creates related objects together.

*/

using System;

// ================= PRODUCT INTERFACES =================

// Abstract Product A
interface IKeyboard
{
    void Type();
}

// Abstract Product B
interface IMouse
{
    void Click();
}



// ================= CONCRETE PRODUCTS =================

// ASUS Keyboard
class AsusKeyboard : IKeyboard
{
    public void Type()
    {
        Console.WriteLine("Typing with ASUS Keyboard");
    }
}

// ASUS Mouse
class AsusMouse : IMouse
{
    public void Click()
    {
        Console.WriteLine("Clicking ASUS Mouse");
    }
}



// MSI Keyboard
class MsiKeyboard : IKeyboard
{
    public void Type()
    {
        Console.WriteLine("Typing with MSI Keyboard");
    }
}

// MSI Mouse
class MsiMouse : IMouse
{
    public void Click()
    {
        Console.WriteLine("Clicking MSI Mouse");
    }
}



// ================= ABSTRACT FACTORY =================

// Factory interface
interface IGamingFactory
{
    IKeyboard CreateKeyboard();

    IMouse CreateMouse();
}



// ================= CONCRETE FACTORIES =================

// ASUS Factory
class AsusFactory : IGamingFactory
{
    public IKeyboard CreateKeyboard()
    {
        return new AsusKeyboard();
    }

    public IMouse CreateMouse()
    {
        return new AsusMouse();
    }
}



// MSI Factory
class MsiFactory : IGamingFactory
{
    public IKeyboard CreateKeyboard()
    {
        return new MsiKeyboard();
    }

    public IMouse CreateMouse()
    {
        return new MsiMouse();
    }
}



// ================= CLIENT =================

class Program
{
    static void Main(string[] args)
    {
        // choose brand factory
        IGamingFactory factory;

        Console.WriteLine("Choose Brand:");
        Console.WriteLine("1. ASUS");
        Console.WriteLine("2. MSI");

        int choice = Convert.ToInt32(Console.ReadLine());



        // create factory object
        if (choice == 1)
        {
            factory = new AsusFactory();
        }
        else
        {
            factory = new MsiFactory();
        }



        // create related objects
        IKeyboard keyboard = factory.CreateKeyboard();

        IMouse mouse = factory.CreateMouse();



        // use products
        keyboard.Type();

        mouse.Click();
    }
}