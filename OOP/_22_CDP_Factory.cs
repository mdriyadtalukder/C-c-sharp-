using System;

// ================= PRODUCT INTERFACE =================
interface IAnimal
{
    void Speak();
}

// ================= CONCRETE CLASSES =================
class Dog : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Dog barks");
    }
}

class Cat : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Cat meows");
    }
}

class Cow : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Cow moos");
    }
}

// ================= FACTORY INTERFACE =================
interface IAnimalFactory
{
    IAnimal CreateAnimal(string type);
}

// ================= CONCRETE FACTORY =================
class AnimalFactory : IAnimalFactory
{
    public IAnimal CreateAnimal(string type)
    {
        switch (type.ToLower())
        {
            case "dog":
                return new Dog();

            case "cat":
                return new Cat();

            case "cow":
                return new Cow();

            default:
                throw new ArgumentException("Invalid animal type");
        }
    }
}

// ================= PROGRAM =================
class Program
{
    static void Main(string[] args)
    {
        IAnimalFactory factory = new AnimalFactory();

        IAnimal animal1 = factory.CreateAnimal("dog");
        animal1.Speak();

        IAnimal animal2 = factory.CreateAnimal("cat");
        animal2.Speak();

        IAnimal animal3 = factory.CreateAnimal("cow");
        animal3.Speak();
    }
}