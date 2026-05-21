/*

Definition:
The State Pattern is used to allow an object to change its behavior when its internal state changes.

Simple Idea

An object behaves differently depending on its current state.

Real-life Example

Traffic Light

Red → Stop
Yellow → Wait
Green → Go

The same traffic light behaves differently based on its current state.

*/

using System;

// State Interface
interface IState
{
    void Handle();
}

// Concrete State - Red
class RedState : IState
{
    public void Handle()
    {
        Console.WriteLine("Stop");
    }
}

// Concrete State - Green
class GreenState : IState
{
    public void Handle()
    {
        Console.WriteLine("Go");
    }
}

// Context
class TrafficLight
{
    private IState state;

    public void SetState(IState state)
    {
        this.state = state;
    }

    public void ApplyState()
    {
        state.Handle();
    }
}

// Client
class Program
{
    static void Main()
    {
        TrafficLight light = new TrafficLight();

        light.SetState(new RedState());
        light.ApplyState();

        light.SetState(new GreenState());
        light.ApplyState();
    }
}