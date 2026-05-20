/*
Definition:
The Command Pattern turns a request/action into an object, so you can store, queue, undo, or execute commands later.

Simple idea:
Instead of calling an action directly, we create a command object that contains the request.

Real-life Example:
A TV Remote → When you press a button, the remote sends a command like Turn ON TV or Turn OFF TV.

The remote does not directly call the TV method. It sends the command to a Command object, and that command object tells the TV what to do.

Flow:

Button Press
      ↓
Remote (Invoker)
      ↓
Command Object
      ↓
TV (Receiver)
*/

using System;

// Receiver
class TV
{
    public void TurnOn()
    {
        Console.WriteLine("TV is ON");
    }

    public void TurnOff()
    {
        Console.WriteLine("TV is OFF");
    }
}

// Command Interface
interface ICommand
{
    void Execute();
}

// Concrete Command - Turn ON
class TurnOnCommand : ICommand
{
    private TV tv;

    public TurnOnCommand(TV tv)
    {
        this.tv = tv;
    }

    public void Execute()
    {
        tv.TurnOn();
    }
}

// Concrete Command - Turn OFF
class TurnOffCommand : ICommand
{
    private TV tv;

    public TurnOffCommand(TV tv)
    {
        this.tv = tv;
    }

    public void Execute()
    {
        tv.TurnOff();
    }
}

// Invoker
class RemoteControl
{
    private ICommand command;

    public void SetCommand(ICommand command)
    {
        this.command = command;
    }

    public void PressButton()
    {
        command.Execute();
    }
}

// Client
class Program
{
    static void Main()
    {
        TV tv = new TV();

        ICommand turnOn = new TurnOnCommand(tv);
        ICommand turnOff = new TurnOffCommand(tv);

        RemoteControl remote = new RemoteControl();

        remote.SetCommand(turnOn);
        remote.PressButton();

        remote.SetCommand(turnOff);
        remote.PressButton();
    }
}