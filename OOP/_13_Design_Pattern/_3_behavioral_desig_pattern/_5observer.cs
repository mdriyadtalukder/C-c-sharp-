/*
Definition:
The Observer Pattern defines a one-to-many dependency between objects so that when one object (Subject) changes state, all its dependent objects (Observers) are automatically notified.

Simple Idea

When something changes in one place, everyone who is watching gets updated automatically.

Real-life Example

YouTube Channel Subscription

You subscribe to a channel (Observer)
Channel uploads a video (Subject changes state)
All subscribers get notification automatically
YouTube Channel (Subject)
        ↓
Subscriber A, B, C (Observers)
*/
using System;
using System.Collections.Generic;

// Observer Interface
interface IObserver
{
    void Update(string news);
}

// Subject Interface
interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify();
}

// Concrete Subject
class NewsAgency : ISubject
{
    private List<IObserver> observers = new List<IObserver>();
    private string news;

    public void SetNews(string news)
    {
        this.news = news;
        Notify();
    }

    public void Attach(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in observers)
        {
            observer.Update(news);
        }
    }
}

// Concrete Observer
class NewsChannel : IObserver
{
    private string name;

    public NewsChannel(string name)
    {
        this.name = name;
    }

    public void Update(string news)
    {
        Console.WriteLine(name + " received news: " + news);
    }
}

// Client
class Program
{
    static void Main()
    {
        NewsAgency agency = new NewsAgency();

        IObserver cnn = new NewsChannel("CNN");
        IObserver bbc = new NewsChannel("BBC");

        agency.Attach(cnn);
        agency.Attach(bbc);

        agency.SetNews("Breaking: Observer Pattern explained!");
    }
}