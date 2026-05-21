/*
The Memento Pattern is used to save and restore an object's previous state without exposing its internal details.

Simple Idea

It lets you save history (backup) of an object and go back to an old state later.

Real-life Example

Undo feature in a text editor

You write:

Hello

Then change to:

Hello Riyad

Press Undo → back to:

Hello

The old state was saved using Memento Pattern.
*/
using System;

// Memento
class Memento
{
    public string State { get; }

    public Memento(string state)
    {
        State = state;
    }
}

// Originator
class Editor
{
    public string Content { get; set; }

    public Memento Save()
    {
        return new Memento(Content);
    }

    public void Restore(Memento memento)
    {
        Content = memento.State;
    }
}

// Caretaker
class History
{
    public Memento Memento { get; set; }
}

// Client
class Program
{
    static void Main()
    {
        Editor editor = new Editor();
        History history = new History();

        editor.Content = "Hello";
        history.Memento = editor.Save(); // Save state

        editor.Content = "Hello Riyad";
        Console.WriteLine(editor.Content);

        editor.Restore(history.Memento); // Undo
        Console.WriteLine(editor.Content);
    }
}