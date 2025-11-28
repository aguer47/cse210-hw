
// Added a fourth activity called Gratitute Activity.
// Added a session log for tracking how many activities have been  completed.
// Added  smoother animations
// Reflection questions don not repeat untill all have been used once


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! welcome to Mindfulness Project.");

        int totalActivitiesCompleted = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Program");

            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Gratitude Activity");
            Console.WriteLine("5. Quit");

            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            Activity activity = choice switch
            {
                "1" => new BreathingActivity(),
                "2" => new ReflectionActivity(),
                "3" => new ListingActivity(),
                "4" => new GratitudeActivity(), 
                "5" => null,
                _ => null
            };

            if (choice == "5")
            {
                Console.WriteLine("Thank you for using the program. Nicetime☺");

                break;
            }

            if (activity == null)
            {
                Console.WriteLine("Invalid choice. Press Enter to try again.");

                Console.ReadLine();
                continue;
            }

            activity.RunActivity();
            totalActivitiesCompleted++;

            Console.WriteLine($"Total activities completed this session: {totalActivitiesCompleted}");

            Console.WriteLine("Press Enter to return to the menu...");

            Console.ReadLine();
        }
    }
}