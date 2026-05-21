/*

The Visitor Pattern is used to add new operations to objects without changing their existing classes.

Simple Idea

Instead of modifying object classes, we create a Visitor that performs operations on them.

Real-life Example

Tax Calculation System

Different items:

Book
Fruit

Same visitor:

Tax Visitor calculates tax for each item differently.
Visitor → Book
        → Fruit

Objects stay the same, but new operations can be added.
*/
using System;

// Visitor Interface
interface IVisitor
{
    void Visit(Book book);
    void Visit(Fruit fruit);
}

// Element Interface
interface IItem
{
    void Accept(IVisitor visitor);
}

// Concrete Element - Book
class Book : IItem
{
    public int Price { get; set; }

    public Book(int price)
    {
        Price = price;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}

// Concrete Element - Fruit
class Fruit : IItem
{
    public int Price { get; set; }

    public Fruit(int price)
    {
        Price = price;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}

// Concrete Visitor
class TaxVisitor : IVisitor
{
    public void Visit(Book book)
    {
        Console.WriteLine("Book Tax: " + (book.Price * 0.1));
    }

    public void Visit(Fruit fruit)
    {
        Console.WriteLine("Fruit Tax: " + (fruit.Price * 0.05));
    }
}

// Client
class Program
{
    static void Main()
    {
        IItem book = new Book(100);
        IItem fruit = new Fruit(50);

        IVisitor visitor = new TaxVisitor();

        book.Accept(visitor);
        fruit.Accept(visitor);
    }
}