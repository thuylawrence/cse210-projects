using System;

class SimpleGoal : Goal
{
    private const int goalType = 1;
    
    private bool _goalComplete;
    public SimpleGoal(bool goalComplete = false): base ()
    {
       
        _goalComplete = goalComplete;
    }

    public SimpleGoal(string goalName, string goalDescription, int points, bool goalComplete) : base(goalName, goalDescription, points)
    {
        _goalComplete = goalComplete;
    }

    public override string ToCSVRecord()
    {
        return $"{goalType}|{getGoalName()}|{getGoalDescription()}|{getGoalPoints()}|{_goalComplete}";
    }
    public override string ToString()
    {
        return $"[{((_goalComplete == false) ? " " : "X")}] {getGoalName()} ({ getGoalDescription()})";
    }
    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {getGoalPoints()}");
        _goalComplete = true;
    }
}
