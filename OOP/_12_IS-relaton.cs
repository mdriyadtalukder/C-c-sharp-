/*
One class is a type of another class

Meaning:

Child class inherits from parent class.

Real-life:
Dog is an Animal
Car is a Vehicle
Key idea:

👉 Uses inheritance
*/
class Animal
{
    public void Eat() { }
}

class Dog : Animal   // Dog IS-A Animal
{
    public void Bark() { }
}