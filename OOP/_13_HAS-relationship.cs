/*
One class has another class inside it

Meaning:

One object contains another object.

Example:
Real-life:
Car has an Engine
Remote has a TV

Key idea:
👉 Uses composition (object inside object)


| IS-A            | HAS-A            |
| --------------- | ---------------- |
| Inheritance     | Composition      |
| “is a type of”  | “has a part of”  |
| Tight coupling  | Loose coupling   |
| Dog IS-A Animal | Car HAS-A Engine |

*/

class Engine
{
    public void Start() { }
}

class Car
{
    private Engine engine = new Engine(); // Car HAS-A Engine

    public void Drive()
    {
        engine.Start();
    }
}