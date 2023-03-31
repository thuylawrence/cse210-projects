public class ReceptionEvent : Event
{
    private string _email;
    public ReceptionEvent(string eventTitle, string eventDescription, string date, string time, string address, string email) : base(eventTitle, eventDescription, date, time, address)
    {
        Type = "Reception Event";
        _email = email;
    }
    public override void DisplayFullDetails()
    {
        Console.WriteLine($"Event Type: {Type}");
        Console.WriteLine($"Event Title: {EventTitle}");
        Console.WriteLine($"Event Description: {EventDescription}");
        Console.WriteLine($"RSVP: {Email}");
        Console.WriteLine(Date);
        Console.WriteLine(Time);
        Console.WriteLine(Address.DisplayAddress());
    }
        
     public void DisplayMessage()
    {
        DisplayMarketingMessage();
    }
     public new void DisplayMarketingMessage()
    {
       Console.WriteLine($"We are here to help our plan your {Type}. All you have to do is contact us, sit back and relax. We will plan a memorable event for you. ");   
    }   

}