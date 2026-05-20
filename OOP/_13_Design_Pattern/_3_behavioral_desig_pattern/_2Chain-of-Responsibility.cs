/*
Definition:
The Chain of Responsibility Pattern passes a request through a chain of handlers, where each handler either:

handles the request, or
passes it to the next handler
Simple Idea

Instead of one object handling everything, we create a chain of objects, and the request travels through them until someone handles it.

Real-life Example

Customer Support System:

Basic Support → Senior Support → Manager

If Basic Support can’t solve the issue, it forwards it to Senior Support, and so on.
*/

using System;

// Handler
abstract class Handler
{
    protected Handler next;

    public void SetNext(Handler nextHandler)
    {
        next = nextHandler;
    }

    public abstract void Handle(int request);
}

// Concrete Handler 1
class LowLevelSupport : Handler
{
    public override void Handle(int request)
    {
        if (request <= 5)
        {
            Console.WriteLine("LowLevelSupport handled request: " + request);
        }
        else if (next != null)
        {
            next.Handle(request);
        }
    }
}

// Concrete Handler 2
class MidLevelSupport : Handler
{
    public override void Handle(int request)
    {
        if (request <= 10)
        {
            Console.WriteLine("MidLevelSupport handled request: " + request);
        }
        else if (next != null)
        {
            next.Handle(request);
        }
    }
}

// Concrete Handler 3
class HighLevelSupport : Handler
{
    public override void Handle(int request)
    {
        Console.WriteLine("HighLevelSupport handled request: " + request);
    }
}

// Client
class Program
{
    static void Main()
    {
        LowLevelSupport low = new LowLevelSupport();
        MidLevelSupport mid = new MidLevelSupport();
        HighLevelSupport high = new HighLevelSupport();

        low.SetNext(mid);
        mid.SetNext(high);

        low.Handle(3);   // handled by low
        low.Handle(7);   // handled by mid
        low.Handle(15);  // handled by high
    }
}