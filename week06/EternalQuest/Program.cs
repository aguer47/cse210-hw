using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {

        List<Goal> goals = new List<Goal>();
        int score = 0;
        int totalGoalsCompleted = 0;
        int level = 1;

        while (true)
        {
            Console.Clear();
            Console.WriteLine(" Hello World! wellcome to EternalQuest Program. ");
            Console.WriteLine($"Score: {score} | Level: {level} | Goals Completed: {totalGoalsCompleted}");
            Console.WriteLine("----------------------");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Quit");
            Console.Write("Choose: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Choose goal type:");

                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.WriteLine("4. Bad Habit Goal");
                Console.Write("Choice: ");
                string g = Console.ReadLine();

                Console.Write("Goal Name: ");
                string name = Console.ReadLine();
                Console.Write("Description: ");
                string desc = Console.ReadLine();

                if (g == "1")
                {
                    Console.Write("Points: ");
                    int points = int.Parse(Console.ReadLine());
                    goals.Add(new SimpleGoal(name, desc, points));
                }
                else if (g == "2")
                {
                    Console.Write("Points per completion: ");
                    int points = int.Parse(Console.ReadLine());
                    goals.Add(new EternalGoal(name, desc, points));
                }
                else if (g == "3")
                {
                    Console.Write("Points each time: ");
                    int points = int.Parse(Console.ReadLine());
                    Console.Write("Target times: ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("Bonus on final completion: ");
                    int bonus = int.Parse(Console.ReadLine());
                    goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                }
                else if (g == "4")
                {
                    Console.Write("Penalty points: ");
                    int penalty = int.Parse(Console.ReadLine());
                    goals.Add(new BadHabitGoal(name, desc, penalty));
                }

                Console.WriteLine("Goal Created!");
                Console.ReadKey();
            }
            else if (choice == "2")
            {
                Console.WriteLine(" GOALS LIST ");
                int i = 1;
                foreach (Goal goal in goals)
                {
                    Console.WriteLine($"{i}. {goal.GetStatus()} {goal.GetName()} — {goal.GetDescription()}");
                    i++;
                }
                Console.ReadKey();
            }
            else if (choice == "3")
            {
                Console.WriteLine("Which goal did you complete?");

                for (int i = 0; i < goals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {goals[i].GetName()}");
                }
                Console.Write("Choice: ");
                int index = int.Parse(Console.ReadLine()) - 1;

                int gained = goals[index].RecordEvent();
                score += gained;

                
                if (goals[index] is SimpleGoal sg && sg.IsComplete())
                    totalGoalsCompleted++;

                if (goals[index] is ChecklistGoal cg && cg.IsComplete())
                    totalGoalsCompleted++;

                
                while (score >= level * 1000)
                {
                    level++;
                    Console.WriteLine($" LEVEL UP! You reached Level {level}! 👍🤩");
                }

                if (gained >= 0)
                    Console.WriteLine($"You gained {gained} points ❤");
                else
                    Console.WriteLine($"You lost {-gained} points due to a bad habit😥");

                Console.ReadKey();
            }
            else if (choice == "4")
            {
                Console.WriteLine("NICETIME☺");
                break;
            }
        }


    }
}