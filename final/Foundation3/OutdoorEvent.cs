internal class OutdoorEvent : Event
{
    private string _weather;
    public OutdoorEvent(string eventTitle, string eventDescription, string date, string time, string address, string weather) : base(eventTitle, eventDescription, date, time, address)
    {
        Type = "Outdoor Event";
        _weather = weather;
    }
    public override void DisplayFullDetails()
    {
        Console.WriteLine($"Event Type: {Type}");
        Console.WriteLine($"Event Title: {EventTitle}");
        Console.WriteLine($"Event Description: {EventDescription}");
        Console.WriteLine($"Weather: {Weather}");
        Console.WriteLine(Date);
        Console.WriteLine(Time);
        Console.WriteLine(Address.DisplayAddress());
    }
     public new void DisplayMarketingMessage()
    {
       Console.WriteLine($"We are here to help our plan your {Type}. All you have to do is contact us, sit back and relax. We will plan a memorable event for you. ");
    }
}