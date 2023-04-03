using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Activity> activities = new List<Activity>();
        Activity running = new Running("Running", "01 Jun 2023", 30, 3.5);
        activities.Add(running);
        Activity cycling = new Cycling("Cycling", "01 Jun 2023", 60, 10);
        activities.Add(cycling);
        Activity swimming = new Swimming("Swimming", "01 Jun 2023", 60, 15);
        activities.Add(swimming);

        foreach (Activity currentActivity in activities)
        {
            currentActivity.DisplaySummary();
            Console.WriteLine();
        }

    }
}