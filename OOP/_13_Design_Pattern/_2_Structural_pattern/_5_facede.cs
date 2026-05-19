/*
Facade Pattern is a structural design pattern used to provide a simple interface to a complex system.

Simple definition:

Facade Pattern hides complexity and provides one simple interface to use many subsystems.

Real-life example 📱

Think of a TV remote.

To watch TV, many things happen:

Turn on TV
Turn on speaker
Set HDMI input

But you press one button only.

👉 Remote = Facade

It hides all complexity.


| Advantages                                      | Disadvantages                                 |
| ----------------------------------------------- | --------------------------------------------- |
| Hides system complexity                         | Can become too large (God class)              |
| Easy to use                                     | Adds extra abstraction layer                  |
| Reduces dependency between client and subsystem | Less flexibility to access subsystem directly |
| Cleaner code                                    | May hide useful subsystem features            |


*/

using System;

// Subsystems
class TV
{
    public void On()
    {
        Console.WriteLine("TV ON");
    }
}

class Speaker
{
    public void On()
    {
        Console.WriteLine("Speaker ON");
    }
}

class DVDPlayer
{
    public void Play()
    {
        Console.WriteLine("Movie Playing");
    }
}

// Facade
class HomeTheaterFacade //remote
{
    private TV tv = new TV();
    private Speaker speaker = new Speaker();
    private DVDPlayer dvd = new DVDPlayer();

    public void WatchMovie()
    {
        tv.On();
        speaker.On();
        dvd.Play();
    }
}

// Client
class Program
{
    static void Main()
    {
        HomeTheaterFacade home = new HomeTheaterFacade();

        // One simple method
        home.WatchMovie();
    }
}