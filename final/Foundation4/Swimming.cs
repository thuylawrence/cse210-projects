class Swimming : Activity
{
    private int _laps;
    public Swimming(int minutes, int laps) : base(minutes)
    {
        _activityName = "Swimming";
        
        _laps = laps;
    }

    
    public override double GetDistance()
    {
        _distance = (_laps * 50)/(1000 * 0.62);
        return (_laps * 50)/(1000 * 0.62);
    }
   
    public override double GetPace()
    {
        return 60/GetSpeed();
    }
    public override double GetSpeed()
    {
        return (GetDistance()/_minutes)*60;
    }

    public override void DisplaySummary()
    {
        
        Console.WriteLine($"{GetDate()} {_activityName} ({_minutes} min) - Distance {Math.Round(GetDistance(),2)} miles, Speed {Math.Round(GetSpeed(),2)} mph, Pace: {GetPace()} min per mile.");
    
   
    }

}



    

    


   

