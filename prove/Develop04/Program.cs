using System;
 
class Program
{
    static void Main(string[] args)
    {
        bool running = true;
 
        while (running)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Start imagination activity");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");
 
            string choice = Console.ReadLine();
 
            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity(
                    "Breathing Activity",
                    "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathing.RunActivity();
            }
            else if (choice == "2")
            {
                ReflectionActivity reflection = new ReflectionActivity(
                    "Reflection Activity",
                    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflection.RunActivity();
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity(
                    "Listing Activity",
                    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listing.RunActivity();
            }
            else if (choice == "4")
            {
                ImaginationActivity imagination = new ImaginationActivity(
                    "Imagination Activity",
                    "This activity will help you grow your imagination by guiding you to picture a scene and the details inside it. Relax and let your mind wander.");
                imagination.RunActivity();
            }
            else if (choice == "5")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Press enter to try again.");
                Console.ReadLine();
            }
        }
    }
}