public class ReflectingActivity : Activity
{
    public ReflectingActivity() : base ("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."){}

     public void DoActivity()
   {
        WelcomeMessage();
       private List<string> _prompts = new List<string>()
       {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
       };
       Random random = new Random();


        DisplayAnimation();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);
       
       

        EndMessage();
   }
   

}