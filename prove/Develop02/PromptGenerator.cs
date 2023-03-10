
class PromptGenerator
{
    private List<string> _prompts = new List<string>()
    {
        "What was the best thing that you ate today? ",
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
    };
    Random random = new Random();
    public PromptGenerator()
    {
        
    }
    public string GetRandomPrompt()
    {
        string randomPrompt = _prompts[random.Next(0, _prompts.Count()-1)];
        return randomPrompt;
    }
}