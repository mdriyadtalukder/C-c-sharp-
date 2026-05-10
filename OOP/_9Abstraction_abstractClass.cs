using System;
//👉 Abstraction is an idea/concept in OOP.and abstract is the tool used to achieve abstraction.
abstract class Animal //abstract classs..in c++  abstract keyword does not mentioned..
{
    public abstract void Sound();//future e implement hbe in inheritated child class..thos concept Abstraction
    //public virtual void Sound() = 0; //in c++..pure virtual funtion
}

class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Dog barks");
    }
    // public void Sound() // in c++..
    // {
    //     cout << "Hello Child" << endl;
    // }
}

class Program
{
    static void Main(string[] args)
    {
        Dog d = new Dog();
        d.Sound();
    }
}