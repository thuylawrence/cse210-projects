public abstract class Activity
{
    protected string _activityName;
    protected int _minutes;
    protected double _speed, _distance;
    protected string _date ;
    protected Activity(int minutes)
    {
        _date = DateTime.Now.ToShortDateString();
        _minutes = minutes;
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
        return _minutes;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    
    
    public abstract double GetPace();
    
    public abstract void DisplaySummary();
   
    
   

}