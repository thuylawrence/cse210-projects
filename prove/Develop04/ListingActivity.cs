public class ListingActivity : Activity 
{
   public ListingActivity() : base ("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
){}

   public void DoActivity()
   {
        WelcomeMessage();
        

        

        EndMessage();
   }
   public class GetRandom

   {
        private List<string> _prompts1 = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"

        };
        
        public GetRandom(List<string> prompt)
        {
            _prompts1 = prompt;
        }
        public void PromptGenerator()
        {
            Random random = new Random();
            int index = random.Next(_prompts1.Count);
            string randomString = _prompts1[index];
        }
        public string GetPrompts1()
        {
            return randomString;
        }
   }

}