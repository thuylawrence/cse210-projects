using System;

public class Activity
{
    protected string _activityName;

    protected string _description;

    protected int _duration;
    protected Random ran = new Random();
    

    public Activity (string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
       
    }
    protected void WelcomeMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine(_description);
        Console.Write("How long, in seconds, would you like for your session?");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        DisplayAnimation();
        StartActivity = DateTime.Now;
    }
    protected DateTime StartActivity;
    protected void EndMessage()
    {
        Console.WriteLine("Well Done!");
        CountDown();
        Console.WriteLine($"You have completed {_duration} seconds of the {_activityName}");
        CountDown();
    }
    
    protected void DisplayAnimation()
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b");
        }
    }
    protected void CountDown()
    {
        for (int i = 5; i> 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b");
        }
        
    }
}