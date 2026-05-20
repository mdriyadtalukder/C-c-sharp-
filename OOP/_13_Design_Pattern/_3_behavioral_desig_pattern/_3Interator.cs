/*
The Iterator Pattern provides a way to access elements of a collection sequentially (one by one) without exposing its internal structure.

Simple Idea

You can walk through a list (or collection) without knowing how it is stored internally.

Real-life Example

A TV remote channel button:

Press Next → next channel
Press Previous → previous channel

You don’t know how channels are stored internally.

*/
using System;
using System.Collections.Generic;

// Iterator Interface
interface IIterator<T>
{
    bool HasNext();
    T Next();
}

// Concrete Iterator
class NameIterator : IIterator<string>
{
    private List<string> names;
    private int index = 0;

    public NameIterator(List<string> names)
    {
        this.names = names;
    }

    public bool HasNext()
    {
        return index < names.Count;
    }

    public string Next()
    {
        return names[index++];
    }
}

// Aggregate (Collection)
class NameCollection
{
    private List<string> names = new List<string>();

    public void Add(string name)
    {
        names.Add(name);
    }

    public IIterator<string> CreateIterator()
    {
        return new NameIterator(names);
    }
}

// Client
class Program
{
    static void Main()
    {
        NameCollection collection = new NameCollection();

        collection.Add("Riyad");
        collection.Add("John");
        collection.Add("Alice");

        IIterator<string> iterator = collection.CreateIterator();

        while (iterator.HasNext())
        {
            Console.WriteLine(iterator.Next());
        }
    }
}