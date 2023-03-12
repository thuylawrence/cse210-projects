using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Scripture scripture = new Scripture();
        string userChoice = "";
        Console.Clear();
        
    
        while (userChoice != "QUIT" && !scripture.AllWordHidden())
        {
          
            scripture.DisplayScripture(); 
            Console.WriteLine("Press Enter to continue or type 'quit' to finish");
            userChoice = Console.ReadLine();
            if (userChoice == "") 
            {
                scripture.HideWords();
                Console.Clear();
            }
            
            else 
            {
                Console.Write("Invalid Input");
                Console.ReadLine();
            }

        }
        
        
    }
}