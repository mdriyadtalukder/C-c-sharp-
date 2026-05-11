using System;
/*
🔹 Polymorphism Interview Definition

“Polymorphism is an OOP concept where the same method, object, or interface can have different behaviors depending on the object or context.”

🔹 Simple Explanation

👉 “Poly” means many
👉 “Morph” means forms

So:

Polymorphism = many forms
🔹 Describe with Example

“For example, a Sound() method behaves differently for different classes:

Dog → bark
Cat → meow

Same method name, different behavior.”

🔹 Mention Types (Very Important)

“In C#, polymorphism is mainly of two types:

Compile-time polymorphism (method overloading)
Runtime polymorphism (method overriding using virtual and override)”
*/
class MathOps
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}

class Program
{
    static void Main(string[] args)
    {
        MathOps m = new MathOps();

        Console.WriteLine(m.Add(2, 3));
        Console.WriteLine(m.Add(2, 3, 4));
    }
}