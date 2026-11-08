using System;
using System.Collections.Generic;
 
public class ListingActivity : BaseActivity
{
    private List<string> _prompts;
 
    public ListingActivity(string name, string description)
        : base(name, description)
    {
        SetPrompts();
    }
 
    public void RunActivity()
    {
        StartActivity();
 
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {GetPromptString(_prompts)} ---");
        Console.WriteLine();
        RunCountDownMessage("You may begin in:", 5);
        Console.WriteLine();
 
        StartTime();
        int count = 0;
        while (!HasTimerExpired())
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                count++;
            }
        }
 
        Console.WriteLine();
        Console.WriteLine($"You listed {count} items!");
 
        DisplayEnding();
    }
 
    private void SetPrompts()
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }
}