/*
The Strategy Pattern is used to define multiple algorithms (strategies) and make them interchangeable at runtime.

Simple Idea

You can change behavior/algorithm without changing the main object.

Real-life Example

Google Maps Route

You can choose different strategies:

Car Route
Walking Route
Bike Route

Same app, different route strategy.
*/
using System;

// Strategy Interface
interface IPaymentStrategy
{
    void Pay(int amount);
}

// Concrete Strategy - Credit Card
class CreditCardPayment : IPaymentStrategy
{
    public void Pay(int amount)
    {
        Console.WriteLine("Paid " + amount + " using Credit Card");
    }
}

// Concrete Strategy - PayPal
class PayPalPayment : IPaymentStrategy
{
    public void Pay(int amount)
    {
        Console.WriteLine("Paid " + amount + " using PayPal");
    }
}

// Context
class PaymentContext
{
    private IPaymentStrategy strategy;

    public void SetStrategy(IPaymentStrategy strategy)
    {
        this.strategy = strategy;
    }

    public void MakePayment(int amount)
    {
        strategy.Pay(amount);
    }
}

// Client
class Program
{
    static void Main()
    {
        PaymentContext payment = new PaymentContext();

        payment.SetStrategy(new CreditCardPayment());
        payment.MakePayment(100);

        payment.SetStrategy(new PayPalPayment());
        payment.MakePayment(200);
    }
}