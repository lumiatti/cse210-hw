public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    
    public void Display()
    {
        Console.WriteLine($"{_date} - {_promptText}");
        Console.WriteLine("");
        Console.WriteLine($"{_entryText}");
        Console.ReadLine();
    }
}