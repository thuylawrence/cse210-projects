class Cycling : Activity
{
   
    public Cycling(int minutes, double speed) : base(minutes)
    {
        _activityName = "Cycling";
        _speed = speed;
    }
    public override double GetDistance()
    {
        return _speed *(_minutes/60);
    }
    public override double GetPace()
    {
        return 60/_speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override void DisplaySummary()
    {
        Console.WriteLine($"{GetDate()} {_activityName} ({_minutes} min) - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile.");
    }
    

    
   
}

    


    

   
