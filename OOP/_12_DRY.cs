/*❌ Bad
class Dog
{
    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
}

class Cat
{
    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
}
*/
//✅ Good
using System;

class Animal
{
    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
}

class Dog : Animal
{
}

class Cat : Animal
{
}

class Program
{
    static void Main(string[] args)
    {
        Dog d = new Dog();
        d.Eat();

        Cat c = new Cat();
        c.Eat();
    }
}