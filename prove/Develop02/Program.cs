using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        Entry anEntry = new Entry();
        anEntry._date = "09/03 09:34";
        anEntry._entryText = "test entry";
        anEntry._promptText = "test prompt";

        anEntry.Display();
    }
}