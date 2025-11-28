using System;
using System.Threading;

public abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    protected int Duration => _duration;

    public void RunActivity()
    {
        DisplayStartMessage();
        PerformActivity();
        DisplayEndMessage();
    }

    private void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"--- {_name} ---\n");
        Console.WriteLine(_description);
        Console.Write("\nEnter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nPrepare to begin...");
        ShowSpinner(3);
        Console.Clear();
    }

    private void DisplayEndMessage()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(3);

        Console.WriteLine($"\nYou have completed the {_name} activity for {_duration} seconds.");
        ShowSpinner(4);
    }

    // animations
    protected void ShowSpinner(int seconds)
    {
        string[] symbols = { "|", "/", "-", "\\" };
        int i = 0;

        for (int count = 0; count < seconds * 4; count++)
        {
            Console.Write($"\r{symbols[i]}");
            Thread.Sleep(250);
            i = (i + 1) % symbols.Length;
        }

        Console.Write("\r ");
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{i}   ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    
    protected abstract void PerformActivity();
}
