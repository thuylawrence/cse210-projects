public abstract class Activity
{
    protected string _activityName, _date;
    protected double _length;
    protected double _speed;
    protected double _pace;
    protected double _distance;
    protected Activity(string activityName, string date, double length)
    {
        _activityName = activityName;
        _date = date;
        _length = length;
    }
    public string GetActivityName()
    {
        return _activityName;
    }
    public string GetDate()
    {
        return _date;
    }
    public double GetLength()
    {
        return _length;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    
    public abstract double GetPace();
    public abstract string GetSummary();
    public void DisplaySummary()
    {
        Console.WriteLine($"{_date} {_activityName} - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace {GetPace()} min per mile.");
    }
   
    
   

}