using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity",
               "This activity will help you relax by walking you through slow breathing. Clear your mind and focus on your breathing.")
    { }

    protected override void PerformActivity()
    {
        int elapsed = 0;

        while (elapsed < Duration)
        {
            Console.WriteLine("Breathe in...");
            Countdown(3);
            elapsed += 3;

            if (elapsed >= Duration) break;

            Console.WriteLine("Breathe out...");
            Countdown(3);
            elapsed += 3;
        }
    }
}
