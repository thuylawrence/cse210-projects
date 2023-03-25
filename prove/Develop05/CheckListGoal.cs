using System;

class CheckListGoal : Goal
{
    private const int goalType = 3;
    private int _bonus, _timesCompleted, _timesNeededCompleted;
    private bool _goalComplete = false;
     public CheckListGoal() : base()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _timesNeededCompleted = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonus = int.Parse(Console.ReadLine());
        
    }
    public CheckListGoal(string goalName, string goalDescription, int points, int bonus, int timesCompleted, int timesNeeded ) : base(goalName, goalDescription, points)
    {
        _bonus = bonus;
        _timesCompleted = timesCompleted;
        _timesNeededCompleted = timesNeeded;
    }

    public override void RecordEvent()
    {
        if (_timesCompleted != _timesNeededCompleted)
        {
            _timesCompleted ++;
            Console.WriteLine($"Congratulations! You have earned {getGoalPoints()}"); 
        }
        
    }

    public override string ToCSVRecord()
    {

        return $"{goalType}|{getGoalName()}|{getGoalDescription()}|{getGoalPoints()}|{_bonus}|{_timesCompleted}|{_timesNeededCompleted}|{_goalComplete}";
    }

    public override string ToString()
    {
        return $"[{((_goalComplete == false) ? " " : "X")}] {getGoalName()} ({getGoalDescription()} -- Currently completed; {_timesCompleted}/{_timesNeededCompleted}";
    }
}