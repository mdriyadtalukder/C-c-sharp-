using System;
/*
Decorator Pattern is a structural design pattern used to add new behavior/features to an object dynamically without changing the original class.

Simple definition:

Decorator Pattern adds extra functionality to an object by wrapping it.

Real-life example 🍔

Think of a burger:

Basic burger = object
Add cheese = decorator
Add sauce = decorator
Add extra chicken = decorator

You are adding features without changing the original burger.
*/
// Base interface
interface ICoffee
{
    string GetDescription();
    int GetCost();
}

// Original object
class SimpleCoffee : ICoffee
{
    public string GetDescription()
    {
        return "Simple Coffee";
    }

    public int GetCost()
    {
        return 100;
    }
}

// Decorator
class MilkDecorator : ICoffee
{
    private ICoffee coffee;

    public MilkDecorator(ICoffee coffee)
    {
        this.coffee = coffee;
    }

    public string GetDescription()
    {
        return coffee.GetDescription() + ", Milk";
    }

    public int GetCost()
    {
        return coffee.GetCost() + 20;
    }
}

class Program
{
    static void Main()
    {
        ICoffee coffee = new SimpleCoffee();

        // Add milk feature
        coffee = new MilkDecorator(coffee);

        Console.WriteLine(coffee.GetDescription());
        Console.WriteLine(coffee.GetCost());
    }
}