/*
Definition:
The Mediator Pattern defines an object (Mediator) that centralizes communication between multiple objects, so they don’t communicate directly with each other.

Simple Idea

Instead of objects talking to each other directly, they all talk through a central controller (Mediator).

Real-life Example

Air Traffic Control System

Planes don’t talk to each other directly
All communication goes through Air Traffic Control (Mediator)
Plane A ↔ ATC ↔ Plane B
Plane C ↔ ATC ↔ Plane D
*/
using System;

// Mediator Interface
interface IChatRoom
{
    void SendMessage(string message, User user);
}

// Concrete Mediator
class ChatRoom : IChatRoom
{
    public void SendMessage(string message, User user)
    {
        Console.WriteLine(user.Name + " sends: " + message);
    }
}

// Colleague
class User
{
    public string Name { get; private set; }
    private IChatRoom chatRoom;

    public User(string name, IChatRoom chatRoom)
    {
        Name = name;
        this.chatRoom = chatRoom;
    }

    public void Send(string message)
    {
        chatRoom.SendMessage(message, this);
    }
}

// Client
class Program
{
    static void Main()
    {
        IChatRoom chatRoom = new ChatRoom();

        User user1 = new User("Riyad", chatRoom);
        User user2 = new User("John", chatRoom);

        user1.Send("Hello John!");
        user2.Send("Hi Riyad!");
    }
}