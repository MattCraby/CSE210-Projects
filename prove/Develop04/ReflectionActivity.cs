using System;
using System.Collections.Generic;
 
public class ReflectionActivity : BaseActivity
{
    private List<string> _prompts;
    private List<string> _questions;
 
    public ReflectionActivity(string name, string description)
        : base(name, description)
    {
        SetPromptsAndQuestions();
    }
 
    public void RunActivity()
    {
        StartActivity();
 
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {GetPromptString(_prompts)} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
 
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        RunCountDownMessage("You may begin in:", 5);
        Console.Clear();
 
        StartTime();
        while (!HasTimerExpired())
        {
            DisplaySpinnerMessage($"> {GetPromptString(_questions)}", 10);
        }
 
        DisplayEnding();
    }
 
    private void SetPromptsAndQuestions()
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
 
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }
}
 