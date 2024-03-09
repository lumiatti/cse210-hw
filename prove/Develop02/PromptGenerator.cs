using System.Reflection.Metadata.Ecma335;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetTandomPrompt()
    {
        Console.WriteLine("test");
        return Console.ReadLine();
    }
}