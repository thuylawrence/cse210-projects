using System;

class EternalGoal : Goal
{
    private const int goalType = 2;
    
    public EternalGoal() : base()
    {
        
    }
    public EternalGoal(string goalName, string goalDescription, int points) : base(goalName, goalDescription, points)
    {
    }
    public override string ToCSVRecord()
    {
        return $"{goalType}|{getGoalName()}|{getGoalDescription()}|{getGoalPoints()}";
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {getGoalPoints()}");
    }

    public override string ToString()
    {
        return $"[ ] {getGoalName()} ({getGoalDescription()}";
    }
}