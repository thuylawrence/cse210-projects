using System;

public abstract class Goal
{
    protected string _goalName;
    protected string _goalDescription;
    protected int _points;
    
    protected Goal()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _goalDescription = Console.ReadLine();
        Console.Write("How many points are associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
    }

    public Goal(string goalName, string goalDescription, int points)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _points = points;
    }

    public string getGoalName()
    {
        return _goalName;
    }
    public string getGoalDescription()
    {
        return _goalDescription;
    }
    public int getGoalPoints()
    {
        return _points;
    }
    public abstract string ToCSVRecord();
    public abstract void RecordEvent();
    public void DisplayGetGoalName()
    {
        Console.WriteLine(getGoalName());
    }
    public void DisplayGetGoalDescription()
    {
        Console.WriteLine(getGoalDescription());
    }
    public void DisplayGetGoalPoints()
    {
        Console.WriteLine(getGoalPoints());
    }
}
    