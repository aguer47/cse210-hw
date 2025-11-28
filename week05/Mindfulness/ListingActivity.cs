using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are your personal strengths?",
        "Who have you helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are your personal heroes?"
    };

    public ListingActivity()
        : base("Listing Activity",
               "This activity helps you reflect on the good things in your life by listing as many items as you can.")
    { }

    protected override void PerformActivity()
    {
        Random rand = new Random();
        Console.WriteLine("\nList as many responses as you can to the prompt:");

        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($" --- {prompt} ---");

        Console.WriteLine("\nYou may begin in:");
        Countdown(5);

        List<string> items = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");
    }
}
