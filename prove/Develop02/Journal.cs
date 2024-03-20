using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

public class Journal
 {
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry (Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
      foreach(Entry entry in _entries) 
      {
         entry.Display();
      }
    }
    public void SaveToFile(string file)
    {
      using(StreamWriter streamWriter = new StreamWriter (file))
      {
         foreach(Entry entry in _entries)
         {
            streamWriter.WriteLine($"{entry._date}: {entry._promptText}");
            streamWriter.WriteLine(entry._entryText);
            //Console.WriteLine(entry);
         }
         Console.WriteLine($"Data saved in to file {file} successfully!");   
      }   
    }
    public void LoadFromFile(string file)
    {
      string filename = file;
      string[] lines = System.IO.File.ReadAllLines(filename);

      foreach (string line in lines)
      {
         // string[] parts = line.Split(",");

         // string firstName = parts[0];
         // string lastName = parts[1];
         Console.WriteLine(line);
      }
    }
 }