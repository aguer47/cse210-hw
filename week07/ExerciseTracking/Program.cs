// Have added activity emojis such as running, swimming and cycling.
// Have added summary formatting.
// Have added miles conversion helper method.
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! wellcome to the ExerciseTracking Program.");

        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("03 Nov 2022", 30, 5.0));
        activities.Add(new Cycling("03 Nov 2022", 45, 20.0));
        activities.Add(new Swimming("03 Nov 2022", 25, 30));

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}