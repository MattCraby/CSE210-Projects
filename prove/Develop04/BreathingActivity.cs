using System;
 
public class BreathingActivity : BaseActivity
{
    public BreathingActivity(string name, string description)
        : base(name, description)
    {
    }
 
    public void RunActivity()
    {
        StartActivity();
        StartTime();
 
        while (!HasTimerExpired())
        {
            RunCountDownMessage("Breathe in...", 4);
            RunCountDownMessage("Breathe out...", 6);
        }
 
        DisplayEnding();
    }
}