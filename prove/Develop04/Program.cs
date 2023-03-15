using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        string userResponse = "";
        while (userResponse != "QUIT")
        {
            Console.Clear();
            Console.WriteLine("""
            Menu Options:
            1. Start brething activity
            2. Start reflecting activity
            3. Start listing activity
            4. Quit
            Select a choice from the menu 
            """);
            userResponse = Console.ReadLine();
            if (userResponse == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.DoActivity();
            }
            else if (userResponse == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.DoActivity();
            }
            else if (userResponse == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.DoActivity();

            }
            else if (userResponse == "4")
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