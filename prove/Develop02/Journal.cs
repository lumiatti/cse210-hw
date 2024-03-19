using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

public class Journal
 {
    public List<Entry> _entries;
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

    }
    public void LoadFromFile(string file)
    {

    }
 }