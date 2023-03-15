public class BreathingActivity : Activity 
{
   public BreathingActivity() : base ("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."){}

   public void DoActivity()
   {
        WelcomeMessage();
        //Breath in, breath out loop
        
        DisplayAnimation();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);
        
        for (int i = 5; i> 0; i--)
        {
            Console.Write($"Breathing in... {i} \b \b");
            Console.Write($"Now breath out... {i} \b \b");
            Thread.Sleep(1000);
        }
        
        // int i = 0;

        // while (DateTime.Now < endTime)
        // {
        //     string s = animationStrings [i];
        //     Console.Write (s);
        //     Thread.Sleep(1000);
        //     i ++;
        //     if (i>= animationStrings.count)
        //     {
        //         i=0;
        //     }

        // }

        EndMessage();
   }

}