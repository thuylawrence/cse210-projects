public class LectureEvent : Event
{
    private string _speaker;
    private int _capacity;
    public LectureEvent(string eventTitle, string eventDescription, string date, string time, string address, string speaker, int capacity) : base(eventTitle, eventDescription, date, time, address)
    {
        Type = "Lecture Event";
        _speaker = speaker;
        _capacity = capacity;
    }
     public override void DisplayFullDetails()
    {
        Console.WriteLine(Type);
        Console.WriteLine(EventTitle);
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine(EventDescription);
        Console.WriteLine($"Capacity: {_capacity}");
        Console.WriteLine(Date);
        Console.WriteLine(Time);
        Console.WriteLine(Address.DisplayAddress());
    }
        
     public new void DisplayMarketingMessage()
    {
       Console.WriteLine($"We are here to help our plan your {Type}. All you have to do is contact us, sit back and relax. We will plan a memorable event for you. ");
    }
}