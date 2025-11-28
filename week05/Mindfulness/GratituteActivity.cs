using System;

public class GratitudeActivity : Activity
{
    public GratitudeActivity()
        : base("Gratitude Activity",
               "This activity helps you express gratitude by writing short notes of appreciation.")
    { }

    protected override void PerformActivity()
    {
        int elapsed = 0;
        int count = 0;

        Console.WriteLine("\nWrite short gratitude notes. Type as many as you can!");

        while (elapsed < Duration)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;

            ShowSpinner(1);
            elapsed++;
        }

        Console.WriteLine($"\nYou wrote {count} gratitude notes!");
    }
}
