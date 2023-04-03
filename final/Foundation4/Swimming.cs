class Swimming : Activity
{
    private int _laps;
    public Swimming(string activityName, string date, double length, int laps) : base(activityName, date, length)
    {
        _laps = laps;
    }

    public int laps { get; private set; }

    public override double GetDistance()
    {
        return _laps * 50/1000 * 0.62;
    }
    public int GetLaps()
    {
        return laps;
    }

    public override double GetPace()
    {
        return 60/_pace;
    }
    public override double GetSpeed()
    {
        return 60/_speed;
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

    


   

