public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity(int userDuration) : base(userDuration)
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times..";
        _duration = userDuration;
    }


    public void Run()
    {
        //TODO
    }


    public string GetRandomPrompt()
    {
        return "TODO";
    }


    public string GetRandomQuestion()
    {
        return "TODO";
    }

    
    public void DisplayPrompt()
    {
        //TODO
    }


    public void DisplayQuestions()
    {
        //TODO
    }
}