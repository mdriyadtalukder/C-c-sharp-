/*
Composite Pattern is a structural design pattern used to treat individual objects and groups of objects in the same way.

Simple definition:

Composite Pattern allows you to work with single objects and collections of objects using the same interface.

🧠 Real-life example

Think of a folder system in computer 📁

File → single object
Folder → contains files or other folders

But both can be:

opened
deleted
moved

👉 Same operations apply to both.

❌ Problem without Composite

You treat files and folders differently:

File → print()
Folder → loop + print() for each file

Too complex ❌
✅ Solution: Composite Pattern

We use one common interface.


| Advantages                                                | Disadvantages                                           |
| --------------------------------------------------------- | ------------------------------------------------------- |
| Treats **single objects and groups uniformly**            | Can make design **overly general and complex**          |
| Simplifies client code (same interface for file & folder) | Hard to restrict certain operations (leaf vs composite) |
| Easy to build **tree-like structures** (file system, UI)  | Can become difficult to maintain in large hierarchies   |
| Makes adding new components easy                          | May violate **Single Responsibility Principle**         |
| Supports recursion naturally (folder inside folder)       | Debugging can be harder due to nested structure         |


*/

using System;
using System.Collections.Generic;

// Component (common interface)
interface IFileSystem
{
    void Show();
}

// Leaf (single object)
class File : IFileSystem
{
    private string name;

    public File(string name)
    {
        this.name = name;
    }

    public void Show()
    {
        Console.WriteLine("File: " + name);
    }
}

// Composite (group of objects)
class Folder : IFileSystem
{
    private string name;
    private List<IFileSystem> items = new List<IFileSystem>();

    public Folder(string name)
    {
        this.name = name;
    }

    public void Add(IFileSystem item)
    {
        items.Add(item);
    }

    public void Show()
    {
        Console.WriteLine("Folder: " + name);

        foreach (var item in items)
        {
            item.Show();
        }
    }
}

// Client
class Program
{
    static void Main()
    {
        File file = new File("X-singleFile.txt");

        File file1 = new File("A.txt");
        File file2 = new File("B.txt");

        Folder folder = new Folder("MyFolder");
        folder.Add(file1);
        folder.Add(file2);

        file.Show();
        folder.Show();
    }
}