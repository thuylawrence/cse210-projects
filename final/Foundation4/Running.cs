class Running : Activity
{
    private double _distance;
    public int distance { get; private set; }
    public Running(string activityName, string date, double length, double distance) : base(activityName, date, length)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return distance;
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
        return $"{DisplaySummary}";;
    }

    public override string ToString()
    {
        return base.ToString();
    }
}

   


    

   


