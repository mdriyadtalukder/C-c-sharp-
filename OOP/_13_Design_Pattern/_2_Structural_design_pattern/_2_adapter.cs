using System;
/*
Adapter Pattern is a structural design pattern used to connect two incompatible classes/interfaces.

Real-life example 🔌

Think of a mobile charger adapter:

Your phone needs USB-C
Wall socket gives different plug
Adapter converts(shapes) it so they can work together

Adapter = connector between incompatible things




Easy understanding:
OldPrinter → incompatible class
IPrinter → expected interface
PrinterAdapter → connects them

Without changing OldPrinter, we make it work with new code.
*/
// Target interface (expected)
interface IPrinter
{
    void Print();
}

// Old class (incompatible)
class OldPrinter
{
    public void PrintOld()
    {
        Console.WriteLine("Printing from old printer");
    }
}

// Adapter
class PrinterAdapter : IPrinter
{
    private OldPrinter oldPrinter;

    public PrinterAdapter(OldPrinter oldPrinter)
    {
        this.oldPrinter = oldPrinter;
    }

    public void Print()
    {
        oldPrinter.PrintOld();
    }
}

class Program
{
    static void Main()
    {
        OldPrinter oldPrinter = new OldPrinter();

        // Use adapter
        IPrinter printer = new PrinterAdapter(oldPrinter);

        printer.Print();
    }
}