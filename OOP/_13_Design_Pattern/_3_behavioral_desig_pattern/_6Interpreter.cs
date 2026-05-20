/*
Definition:
The Interpreter Pattern is used to define a representation for a language and provide a way to interpret and evaluate sentences in that language.

Simple Idea

It helps in parsing and evaluating simple grammar or expressions step by step.

🏠 Real-Life Example

Think of a calculator app:

When you type:

10 + 5

The system:

Understands 10
Understands +
Understands 5
Then calculates result = 15

That “understanding + calculation logic” is Interpreter Pattern.
*/
using System;

// Expression Interface
interface IExpression
{
    int Interpret();
}

// Terminal Expression
class Number : IExpression
{
    private int value;

    public Number(int value)
    {
        this.value = value;
    }

    public int Interpret()
    {
        return value;
    }
}

// Non-Terminal Expression (Add)
class Add : IExpression
{
    private IExpression left;
    private IExpression right;

    public Add(IExpression left, IExpression right)
    {
        this.left = left;
        this.right = right;
    }

    public int Interpret()
    {
        return left.Interpret() + right.Interpret();
    }
}

// Non-Terminal Expression (Subtract)
class Subtract : IExpression
{
    private IExpression left;
    private IExpression right;

    public Subtract(IExpression left, IExpression right)
    {
        this.left = left;
        this.right = right;
    }

    public int Interpret()
    {
        return left.Interpret() - right.Interpret();
    }
}

// Client
class Program
{
    static void Main()
    {
        // (5 + 3) - 2
        IExpression expression =
            new Subtract(
                new Add(new Number(5), new Number(3)),
                new Number(2)
            );

        Console.WriteLine("Result: " + expression.Interpret());
    }
}