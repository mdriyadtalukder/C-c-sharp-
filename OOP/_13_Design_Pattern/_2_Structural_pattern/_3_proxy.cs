/*
Proxy Pattern is a structural design pattern used to control access to an object.

Simple definition:

Proxy Pattern provides a substitute (middle object) that controls access to the real object.

Real-life example 🚪

Think of a security guard at an office.

You don’t directly enter the CEO room.

You → Security Guard (Proxy) → CEO

The guard:

checks permission ✅
controls access ✅
may block entry ❌

*/

using System;

// Common interface
interface IImage
{
    void Display();
}

// Real object
class RealImage : IImage
{
    public RealImage()
    {
        Console.WriteLine("Loading image...");
    }

    public void Display()
    {
        Console.WriteLine("Displaying image");
    }
}

// Proxy
class ImageProxy : IImage
{
    private RealImage realImage;

    public void Display()
    {
        // Load only when needed
        if (realImage == null)
        {
            realImage = new RealImage();
        }

        realImage.Display();
    }
}

class Program
{
    static void Main()
    {
        IImage image = new ImageProxy();

        // Real object not loaded yet
        image.Display();
    }
}