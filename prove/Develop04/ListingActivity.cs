public class ListingActivity : Activity 
{
     private List<string> _prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"

        };
    private List<string> userResponses = new List<string>();
   
        
   public ListingActivity() : base ("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."){}

   public void DoActivity()
   {
        WelcomeMessage();
        Console.WriteLine(_prompts[ran.Next(0,_prompts.Count())]);
        DisplayAnimation();
        
        while (DateTime.Now < StartActivity.AddSeconds(_duration))
        {
            Console.Write("@ ");
            string userResponse = Console.ReadLine();
            userResponses.Add(userResponse);
            
        }
        
        Console.WriteLine($"You listed {userResponses.Count()} items. ");
        

        EndMessage();
   }
   
}