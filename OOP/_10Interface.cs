using System;
//An interface contains method declarations that implementing classes must define.
//c++ does not have interface..it creates by abstract class+pure function in c++
interface IAnimal
{
    void Eat();
}

interface IPet
{
    void Play();
}

class Dog : IAnimal, IPet
{
    public void Eat()
    {
        Console.WriteLine("Dog eats");
    }

    public void Play()
    {
        Console.WriteLine("Dog plays");
    }
}
class Cat : IAnimal
{
    public void Eat()
    {
        Console.WriteLine("Cat eats");
    }


}

class Program
{
    static void Main(string[] args)
    {
        Dog d = new Dog();
        IAnimal c = new Cat();

        d.Eat();
        d.Play();
        c.Eat();
    }
}