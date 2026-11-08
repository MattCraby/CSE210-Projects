using System;
using System.Collections.Generic;
using System.Threading;
 
public class BaseActivity
{
    private string _name;
    private string _description;
    private int _duration;
    private DateTime _endTime;
 
    private static Random _random = new Random();
    private static string[] _spinnerFrames = { "/", "-", "\\", "|" };
 
    public BaseActivity(string name, string description)
    {
        _name = name;
        _description = description;
    }
 
    
    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        ObtainDuration();
        Console.Clear();
        DisplaySpinnerMessage("Get ready...", 3);
        Console.WriteLine();
    }
 
    
    public void DisplayEnding()
    {
        Console.WriteLine();
        DisplaySpinnerMessage("Well done!!", 3);
        Console.WriteLine();
        DisplaySpinnerMessage($"You have completed another {_duration} seconds of the {_name}.", 3);
        Console.Clear();
    }
 
    
    public void RunCountDownMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        Console.Write($"{message} ");
        for (int i = seconds; i >= 1; i--)
        {
            string number = i.ToString();
            Console.Write(number);
            Thread.Sleep(1000);
            
            Console.Write(new string('\b', number.Length));
            Console.Write(new string(' ', number.Length));
            Console.Write(new string('\b', number.Length));
        }
        Console.WriteLine();
        Console.CursorVisible = true;
    }
 
    
    public void DisplaySpinnerMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        Console.Write($"{message} ");
        DateTime spinnerEnd = DateTime.Now.AddSeconds(seconds);
        int frame = 0;
        while (DateTime.Now < spinnerEnd)
        {
            Console.Write(_spinnerFrames[frame]);
            Thread.Sleep(200);
            Console.Write("\b");
            frame = (frame + 1) % _spinnerFrames.Length;
        }
        Console.Write(" ");
        Console.WriteLine();
        Console.CursorVisible = true;
    }
 
    
    public void StartTime()
    {
        _endTime = DateTime.Now.AddSeconds(_duration);
    }
 
    public bool HasTimerExpired()
    {
        return DateTime.Now >= _endTime;
    }
 
    private void ObtainDuration()
    {
        int seconds;
        Console.Write("How long, in seconds, would you like for your session? ");
        while (!int.TryParse(Console.ReadLine(), out seconds) || seconds <= 0)
        {
            Console.Write("Please enter a whole number greater than 0: ");
        }
        _duration = seconds;
    }
 
    
    public string GetPromptString(List<string> prompts)
    {
        return prompts[_random.Next(prompts.Count)];
    }
}