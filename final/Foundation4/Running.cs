class Running : Activity
{
    public Running(int minutes, double distance) : base(minutes)
    {
        _activityName = "Running";
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetPace()
    {
       return _minutes/_distance;
    }
    public override double GetSpeed()
    {
        return (_distance/_minutes)*60;
    }
    public override void DisplaySummary()
    {
        Console.WriteLine($"{GetDate()} {_activityName} ({_minutes} min) - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {Math.Round(GetPace(),2)} min per mile.");
    }
}

    
         
    
   

   


    

   


    
    
