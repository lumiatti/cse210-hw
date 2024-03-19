using System.Reflection.Metadata.Ecma335;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();



    public string GetRandomPrompt()
    {
        int a = 1;
        Random ale = new Random();
        a = ale.Next(_prompts.Count());
        return _prompts[a];
    }
}