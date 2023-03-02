using System.IO;

class Journal
{
   List<Entry> _entries = new List<Entry>();
   
   public void DisplayJournalEntry()
   {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
        Console.ReadLine();
   }
   public void CreateJournalEntry()
   {
        PromptGenerator prompt = new PromptGenerator();
        Entry newEntry = new Entry();
        newEntry.SetPrompt(prompt.GetRandomPrompt());
        Console.WriteLine(newEntry.GetPrompt());
        newEntry.SetResponse(Console.ReadLine());
        _entries.Add(newEntry);
   }
   public void SaveToCSV()
   {
        List<string> records = new List<string>();
        foreach (Entry entry in _entries)
        {
            records.Add(entry.getEntryAsCSV());
        }
        Console.WriteLine("Name of file to save?");
        string _fileName = Console.ReadLine();

        File.WriteAllLines(_fileName, records);
   }
   public void LoadFromCSV()
   {
        Console.WriteLine("Name of file to Load?");
        string _fileName = Console.ReadLine();

        List<string> records = System.IO.File.ReadAllLines(_fileName).ToList();
        foreach (string record in records)
        {
            string[] splitString = record.Split('|');
            Entry entry = new Entry(splitString[0], splitString[1], splitString[2]);
            _entries.Add(entry);
        }
   }
}   
