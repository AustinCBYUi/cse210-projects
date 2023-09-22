public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What did I do this morning I was proud of?"
    };


    public string GetRandomPrompt()
    {
        Random number = new Random();
        int randomNumberPicked = number.Next(0, 1);
        string thePrompt = _prompts[randomNumberPicked];

        return thePrompt;
    }
}