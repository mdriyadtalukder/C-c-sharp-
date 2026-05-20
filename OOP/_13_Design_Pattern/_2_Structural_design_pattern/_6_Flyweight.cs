/*

Flyweight Pattern

Flyweight Pattern is a structural design pattern used to save memory by sharing common objects instead of creating many duplicate objects.

Simple definition:

Flyweight Pattern reduces memory usage by sharing similar objects.
or In Flyweight Pattern, intrinsic (common) data is shared and stored once, while extrinsic (unique) data is stored separately for each object to reduce memory usage.

Imagine this problem 🌳

You are making a game with 1,000 trees.

All trees are:

Green color 🌳
Same shape 🌳
Same size 🌳

Only position changes.
❌ Bad way (without Flyweight)

Create 1000 full objects:

Tree(color=green, shape=big, x=10,y=20)
Tree(color=green, shape=big, x=50,y=80)
Tree(color=green, shape=big, x=100,y=200)

Problem:
Same color + same shape stored 1000 times 😵

Memory waste ❌

✅ Flyweight way

Store common things once:

One Tree Design:
Color = Green
Shape = Big

Then only store positions:

x=10,y=20
x=50,y=80
x=100,y=200

Now:

1 shared tree object ✅
Different positions only ✅
Less memory ✅

| Advantages                            | Disadvantages                   |
| ------------------------------------- | ------------------------------- |
| Saves memory                          | More complex design             |
| Reduces duplicate objects             | Harder to maintain              |
| Improves performance in large systems | Extra logic for sharing objects |
| Good for repeated objects             | Not useful for small systems    |


*/

using System;
using System.Collections.Generic;

// ======================
// Flyweight (Shared part)
// ======================
class TreeType
{
    public string Color;
    public string Shape;

    public TreeType(string color, string shape)
    {
        Color = color;
        Shape = shape;
    }

    public void Display(int x, int y)
    {
        Console.WriteLine($"Tree [{Color}, {Shape}] at ({x}, {y})");
    }
}

// ======================
// Flyweight Factory (Reuse object)
// ======================
class TreeFactory
{
    private static Dictionary<string, TreeType> treeMap = new Dictionary<string, TreeType>();

    public static TreeType GetTreeType(string color, string shape)
    {
        string key = color + "-" + shape;

        if (!treeMap.ContainsKey(key))
        {
            treeMap[key] = new TreeType(color, shape);
            Console.WriteLine("Creating new TreeType: " + key);
        }

        return treeMap[key];
    }
}

// ======================
// Client (Only stores position)
// ======================
class Tree
{
    public int x;
    public int y;
    public TreeType type;

    public Tree(int x, int y, TreeType type)
    {
        this.x = x;
        this.y = y;
        this.type = type;
    }

    public void Draw()
    {
        type.Display(x, y);
    }
}

// ======================
// Main
// ======================
class Program
{
    static void Main()
    {
        // Same tree type reused
        TreeType greenBig = TreeFactory.GetTreeType("Green", "Big");
        TreeType greenBig2 = TreeFactory.GetTreeType("Green", "Big");

        // Different positions, same shared object
        Tree t1 = new Tree(10, 20, greenBig);
        Tree t2 = new Tree(50, 80, greenBig2);
        Tree t3 = new Tree(100, 200, greenBig);

        t1.Draw();
        t2.Draw();
        t3.Draw();
    }
}