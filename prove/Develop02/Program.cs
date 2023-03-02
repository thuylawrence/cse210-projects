using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        Journal journal = new Journal();
        string userResponse = "";
        while (userResponse != "QUIT")
        {
            Console.Clear();
            Console.WriteLine("""
            Please choose one of the following choices!
            1. New Journal Entry
            2. Display Your Journal
            3. Load Your Journal
            4. Save Your Journal
            5. Quit 
            Please type a number (1-5)
            """);
            userResponse = Console.ReadLine();
            if (userResponse == "1")
            {
                journal.CreateJournalEntry();
            }
            else if (userResponse == "2")
            {
                journal.DisplayJournalEntry();
            }
            else if (userResponse == "3")
            {
                journal.LoadFromCSV();
            }
            else if (userResponse == "4")
            {
                journal.SaveToCSV();
            
            }
            else if (userResponse == "5")
            {
                break;
            }
            else 
            {
                Console.Write("Invalid Input");
                Console.ReadLine();
            }
        }
    }
}