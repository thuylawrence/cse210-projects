class Cycling : Activity
{
    private double _speed;
    public Cycling(string activityName, string date, double length, double speed) : base(activityName, date, length)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetPace()
    {
        return _pace;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override string GetSummary()
    {
      return $"{DisplaySummary}";
    }

    public override string ToString()
    {
        return base.ToString();
    }
}

    


    

   
