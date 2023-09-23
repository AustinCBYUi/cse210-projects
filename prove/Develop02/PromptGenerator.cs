public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What did I do this morning I was proud of?",
        "What are three positive things you can think of?",
        "What am I praying for actively?",
        "What do I hope to accomplish today?",
        "Write down three emotions you have felt today."
    };


    public string GetRandomPrompt()
    {
        Random number = new Random();
        int randomNumberPicked = number.Next(0, 6);
        string thePrompt = _prompts[randomNumberPicked];

        return thePrompt;
    }
}