using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();

        scriptures.Add(new Scripture(
            "John", 3, 16,
            "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."));

        scriptures.Add(new Scripture(
            "Proverbs", 3, 5, 6,
            "Trust in the Lord with all thine heart and lean not unto thine own understanding"));

        scriptures.Add(new Scripture(
            "Moses", 1, 39,
            "Behold this is my work and my glory to bring to pass the immortality and eternal life of man."));

        
        

        int choice = 0;
        while (choice < 1 || choice > scriptures.Count)
        {
            Console.Clear();
            Console.WriteLine("Choose a scripture to memorize:");
            for (int i = 0; i < scriptures.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {scriptures[i].GetScriptureReference()}");
            }
            Console.Write("> ");
            int.TryParse(Console.ReadLine(), out choice);
        }

        Scripture scripture = scriptures[choice - 1];

        bool allHidden = false;
        string input = "";

        while (!allHidden && input != "quit")
        {
            Console.Clear();
            scripture.ShowScripture();
            Console.WriteLine();
            Console.Write("Press enter to hide more words, or type 'quit' to exit: ");
            input = Console.ReadLine().Trim().ToLower();

            if (input != "quit")
            {
                allHidden = scripture.HideSomeWords();
            }
        }


        if (allHidden)
        {
            Console.Clear();
            scripture.ShowScripture();
            Console.WriteLine();
        }
    }
}