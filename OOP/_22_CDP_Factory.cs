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
// (This is for simple factory with type parameter - kept as comment style idea)
interface IAnimalFactory
{
    IAnimal CreateAnimal();
}

//// ================= CONCRETE FACTORY (Simple Factory Approach - commented) =================
// class AnimalFactory : IAnimalFactory
// {
//     public IAnimal CreateAnimal(string type)
//     {
//         switch (type.ToLower())
//         {
//             case "dog":
//                 return new Dog();
//
//             case "cat":
//                 return new Cat();
//
//             case "cow":
//                 return new Cow();
//
//             default:
//                 throw new ArgumentException("Invalid animal type");
//         }
//     }
// }


// ================= CONCRETE FACTORIES (FACTORY METHOD WAY) =================

class DogFactory : IAnimalFactory
{
    public IAnimal CreateAnimal()
    {
        return new Dog();
    }
}

class CatFactory : IAnimalFactory
{
    public IAnimal CreateAnimal()
    {
        return new Cat();
    }
}

class CowFactory : IAnimalFactory
{
    public IAnimal CreateAnimal()
    {
        return new Cow();
    }
}

// ================= PROGRAM =================
class Program
{
    static void Main(string[] args)
    {
        // ================= SIMPLE FACTORY (COMMENTED) =================
        /*
        IAnimalFactory factory = new AnimalFactory();

        IAnimal animal1 = factory.CreateAnimal("dog");
        animal1.Speak();

        IAnimal animal2 = factory.CreateAnimal("cat");
        animal2.Speak();

        IAnimal animal3 = factory.CreateAnimal("cow");
        animal3.Speak();
        */

        // ================= FACTORY METHOD =================

        IAnimalFactory dogFactory = new DogFactory();
        IAnimal dog = dogFactory.CreateAnimal();
        dog.Speak();

        IAnimalFactory catFactory = new CatFactory();
        IAnimal cat = catFactory.CreateAnimal();
        cat.Speak();

        IAnimalFactory cowFactory = new CowFactory();
        IAnimal cow = cowFactory.CreateAnimal();
        cow.Speak();
    }
}