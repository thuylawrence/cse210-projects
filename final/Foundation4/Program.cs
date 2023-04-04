using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Activity> activities = new List<Activity>();
        Activity running = new Running( 30, 3.5);
        activities.Add(running);
        Activity cycling = new Cycling( 60, 10);
        activities.Add(cycling);
        Activity swimming = new Swimming( 60, 15);
        activities.Add(swimming);

        foreach (Activity currentActivity in activities)
        {
            currentActivity.DisplaySummary();
            Console.WriteLine();
        }

    }
}