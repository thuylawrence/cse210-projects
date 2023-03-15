using System;

public class Activity
{
    protected string _activityName;

    protected string _description;

    protected int _duration;

    public Activity (string activityName, string decription)
    {
        _activityName = activityName;
        _description = decription;
       
    }
    protected void WelcomeMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine(_description);
        Console.Write("How long, in seconds, would you like for your session?");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        DisplayAnimation();

    }
    protected void EndMessage()
    {
        Console.WriteLine("Well Done!");
        Console.WriteLine($"You have completed {_duration} seconds of the {_activityName}");
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
            Console.Write("\b \b");
        }



    }

}