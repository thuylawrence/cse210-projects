public class BreathingActivity : Activity 
{
   public BreathingActivity() : base ("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."){}

   public void DoActivity()
   {
        WelcomeMessage();
        //Breath in, breath out loop
        
        
        while (DateTime.Now < StartActivity.AddSeconds(_duration))
        {
            Console.WriteLine("Breath in...");
            CountDown();
            Console.WriteLine("Now breath out...");
            CountDown();
        }
        EndMessage();
   }

}