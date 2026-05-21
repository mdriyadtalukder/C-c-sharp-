/*
The Template Method Pattern is used to define the skeleton (steps) of an algorithm in a base class while allowing subclasses to customize specific steps.

Simple Idea

The main process stays fixed, but some steps can be changed.

Real-life Example

Making Tea vs Coffee

Common steps:

Boil water
Add ingredient
Pour into cup

Different step:

Tea → add tea leaves
Coffee → add coffee powder

Same process, different implementation for one step.
*/

using System;

// Abstract Class
abstract class Beverage
{
    // Template Method
    public void PrepareDrink()
    {
        BoilWater();
        AddIngredient();
        PourInCup();
    }

    public void BoilWater()
    {
        Console.WriteLine("Boiling Water");
    }

    public abstract void AddIngredient();

    public void PourInCup()
    {
        Console.WriteLine("Pouring into Cup");
    }
}

// Concrete Class - Tea
class Tea : Beverage
{
    public override void AddIngredient()
    {
        Console.WriteLine("Adding Tea Leaves");
    }
}

// Concrete Class - Coffee
class Coffee : Beverage
{
    public override void AddIngredient()
    {
        Console.WriteLine("Adding Coffee Powder");
    }
}

// Client
class Program
{
    static void Main()
    {
        Beverage tea = new Tea();
        tea.PrepareDrink();

        Console.WriteLine();

        Beverage coffee = new Coffee();
        coffee.PrepareDrink();
    }
}