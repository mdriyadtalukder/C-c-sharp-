/*
“Software entities should be open for extension but closed for modification.”
🔹 Meaning:-
✔ You should be able to add new functionality
❌ Without changing existing code
*/
using System;
//🔴 Bad Example ❌ (Violates OCP)
/*Problem

If you want to add:
Bkash
Crypto
Bank
*/
class Payment
{
    public void Pay(string type)
    {
        if (type == "Card")
        {
            Console.WriteLine("Pay using Card");
        }
        else if (type == "Paypal")
        {
            Console.WriteLine("Pay using Paypal");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Payment p = new Payment();

        p.Pay("Card");
    }
}

/*
🔹 Good Example ✅ (Follows OCP)
using System;

// Interface
interface IPayment
{
    void Pay();
}

// Payment Strategy 1--added 1st one
class CardPayment : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Pay using Card");
    }
}

// Payment Strategy 2 ---added 2nd one..new added class without chance exiting code..its extension..not modify
//i can add more payment as a class like Bkash,Crypto, without modify code
class PaypalPayment : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Pay using Paypal");
    }
}

// New payment added later
class BkashPayment : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Pay using Bkash");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IPayment p1 = new CardPayment();
        p1.Pay();

        IPayment p2 = new PaypalPayment();
        p2.Pay();

        IPayment p3 = new BkashPayment();
        p3.Pay();
    }
}
*/