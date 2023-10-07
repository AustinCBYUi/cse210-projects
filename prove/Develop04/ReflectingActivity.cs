public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>{
        "Think of a time when you stood up for someone else..",
        "Think of a time when you did something really difficult",
        "Think of a time when you helped someone in need"
    };
    private List<string> _questions = new List<string>{
        "Why was this experience meaningful for you?",
        "Have you ever done something like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?"
    };

    public ReflectingActivity(int userDuration) : base(userDuration)
    {
        _duration = userDuration;
    }


    public ReflectingActivity()
    {
        _name = "Reflecting Activity\n";
        _description = "This activity will help you reflect on times in your life you've shown strength and resilience.";
    }


    public void Run()
    {
        DisplayStartingMessage();
        
    }


    private string GetRandomPrompt()
    {
        Random randomNumber = new Random();
        int index = randomNumber.Next(_prompts.Count);
        
        string randomSelection = _prompts[index];

        return randomSelection;
    }


    private string GetRandomQuestion()
    {
        Random randomNumber = new Random();
        int index = randomNumber.Next(_questions.Count);

        string randomSelection = _questions[index];

        return randomSelection;
    }

    
    private void DisplayPrompt()
    {
        string newPrompt = GetRandomPrompt();
        Console.WriteLine(newPrompt);
    }


    private void DisplayQuestions()
    {
        string newQuestion = GetRandomQuestion();
        Console.WriteLine(newQuestion);
    }
}