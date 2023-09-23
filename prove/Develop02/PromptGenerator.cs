public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What did I do this morning I was proud of?",
        "What are three positive things you can think of?",
        "What am I praying for actively?",
        "What do I hope to accomplish today?",
        "Write down three emotions you have felt today.",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };


    public string GetRandomPrompt()
    {
        Random number = new Random();
        int listCounted = _prompts.Count();
        int randomNumberPicked = number.Next(0, listCounted);
        string thePrompt = _prompts[randomNumberPicked];

        return thePrompt;
    }
}