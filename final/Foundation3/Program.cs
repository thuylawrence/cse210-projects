using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Event> events = new List<Event>();
        Event lectureEvent = new LectureEvent("TED TALK", "Guest speaker will speak at the event.", "June 1st, 2023", "TBD", "1 Circle, Salt Lake city, Utah, USA", "Obama", 200);
        events.Add(lectureEvent);
        Event receptionEvent = new ReceptionEvent("Class Reunion", "Class 2000 reunion", "May 1st, 2023", "All Day", "20 Avenue, North Salt Lake, Utah, USA", "classreunion@gmail.com");
        events.Add(receptionEvent);
        Event outdoorEvent = new OutdoorEvent("Dragon Boat Competition", "Guangzhou Boat Racing Competition", "June 30th, 2023", "TBD", "Pearl River, Guangzhou, Guangdong, China", "Sunny");
        events.Add(outdoorEvent);

        foreach (Event currentEvent in events)
        {
            currentEvent.DisplayStandardDetail();
            currentEvent.DisplayFullDetails();
            currentEvent.DisplayShortDescription();
            currentEvent.DisplayMarketingMessage();
            Console.WriteLine();
        }
    }

   
}

  

