
// have added scripture library.
//preserve punctuations if present in word.cs file.
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("Press ENTER to start...");
        Console.ReadLine();
        Console.Clear();

        // Scripture library.
        List<Scripture> library = new List<Scripture>()
        {
            new Scripture(new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son, that whosoever believeth in Him should not perish but have everlasting life."),

            new Scripture(new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding. In all thy ways acknowledge Him, and He shall direct thy paths.")
        };

        
        Random rand = new Random();
        Scripture scripture = library[rand.Next(library.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress ENTER to hide more words, or type 'quit' to end.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                return;

            // hide words here.
            scripture.HideRandomWords(3);

            
            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Press ENTER to exit.");
                Console.ReadLine();
                return;
            }
        }
    }
}
                