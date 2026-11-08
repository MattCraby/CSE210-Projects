using System;
using System.Collections.Generic;
 
public class ImaginationActivity : BaseActivity
{
    private List<string> _scenes;
    private List<string> _details;
 
    public ImaginationActivity(string name, string description)
        : base(name, description)
    {
        SetScenesAndDetails();
    }
 
    public void RunActivity()
    {
        StartActivity();
 
        Console.WriteLine("Close your eyes and imagine the following scene:");
        Console.WriteLine();
        Console.WriteLine($"--- {GetPromptString(_scenes)} ---");
        Console.WriteLine();
        Console.WriteLine("When you have the scene in mind, press enter to continue.");
        Console.ReadLine();
 
        Console.WriteLine("Now let your imagination fill in the scene.");
        RunCountDownMessage("You may begin in:", 5);
        Console.Clear();
 
        StartTime();
        while (!HasTimerExpired())
        {
            DisplaySpinnerMessage($"> {GetPromptString(_details)}", 10);
        }
 
        DisplayEnding();
    }
 
    private void SetScenesAndDetails()
    {
        _scenes = new List<string>
        {
            "Imagine you are standing on a farm early in the morning.",
            "Imagine you are walking along a quiet beach at sunset.",
            "Imagine you are hiking through a peaceful forest.",
            "Imagine you are standing at the top of a tall mountain.",
            "Imagine you are sitting in a garden full of flowers."
        };
 
        _details = new List<string>
        {
            "Imagine all of the animals you can see.",
            "Imagine the colors all around you.",
            "Imagine the sounds you can hear.",
            "Imagine the smells in the air.",
            "Imagine what the ground feels like under your feet.",
            "Imagine the weather and how it feels on your skin.",
            "Imagine who is there with you.",
            "Imagine something surprising that you find there."
        };
    }
}