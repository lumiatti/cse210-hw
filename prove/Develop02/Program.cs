using System;

class Program
{
    static void Main(string[] args)
    {
        string new_value = "";
        List<string> menu = new List<string>();
        menu.Add("1. Write");
        menu.Add("2. Display");
        menu.Add("3. Load");
        menu.Add("4. Save");
        menu.Add("5. Quit");

        PromptGenerator promptGenerator = new PromptGenerator();
        promptGenerator._prompts.Add("If I had one thing I could do over today, What would it be?");
        promptGenerator._prompts.Add("What was the best part of my day?");
        promptGenerator._prompts.Add("Who was the most interesting person I interacted with today?");
    
        Journal journal = new Journal();

        while(new_value != "5")
        {
            Console.WriteLine("Please select one of the following choices!");
            
            foreach(var m in menu)
            {
                Console.WriteLine($"{m}");
            }

            Console.Write("What would you like to do?");
            new_value = Console.ReadLine();
            //Console.WriteLine(new_value);

            if (new_value == "1")
            {
                string strPrompt = promptGenerator.GetRandomPrompt();
                Entry entry = new Entry();
                Console.WriteLine(strPrompt);
                string strEntryText = Console.ReadLine();
                entry._promptText = strPrompt;
                entry._entryText = strEntryText;
                entry._date = DateTime.Now.ToString();

                journal.AddEntry(entry);
            }
            else if (new_value == "2")
            {
               journal.DisplayAll(); 
            }
            else if (new_value == "3")
            {
                Console.WriteLine("What is the file name?");
                string strFileName = Console.ReadLine();
                journal.LoadFromFile(strFileName); 
            }
            else if (new_value == "4")
            {
                Console.WriteLine("What is the file name?");
                string strFileName = Console.ReadLine();
                journal.SaveToFile(strFileName); 
            }
        }
    }
}