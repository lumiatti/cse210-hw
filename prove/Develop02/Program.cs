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
        promptGenerator._prompts.Add("teste1");
        promptGenerator._prompts.Add("teste2");
        promptGenerator._prompts.Add("teste3");
    
        Journal journal = new Journal();

        while(new_value != "5")
        {
            Console.WriteLine("Please select one of the following choices!");
            
            foreach(var m in menu)
            {
                Console.WriteLine($"{m}");
            }

            Console.WriteLine("What would you like to do?");
            new_value = Console.ReadLine();
            Console.WriteLine(new_value);

            if (new_value == "1")
            {
                string recebe = promptGenerator.GetRandomPrompt();
                Entry entry = new Entry();
                Console.WriteLine(recebe);
                string texto = Console.ReadLine();
                entry._promptText = recebe;
                entry._entryText = texto;
                entry._date = DateTime.Now.ToString();

                journal.AddEntry(entry);
            }
            else if (new_value == "2")
            {
                
            }

            // Journal theJournal = new Journal();
            // Entry anEntry = new Entry();
            // anEntry._date = "09/03 09:34";
            // anEntry._entryText = "test entry";
            // anEntry._promptText = "test prompt";

            //anEntry.Display();
        
        }
    }
}