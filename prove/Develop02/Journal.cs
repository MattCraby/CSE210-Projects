using System;
using System.Collections.Generic;
using System.IO;
class Journal
{
    public List<JournalEntry> _entries = new List<JournalEntry>();


    public void DisplayJournal()
    {
        foreach(JournalEntry entry in _entries)
        {
            entry.Display();
        }
    }


    public void CreateEntry()
    {
        JournalEntry newEntry = new JournalEntry();
        newEntry.Create();
        _entries.Add(newEntry);
    }


    public void WriteToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {          
            foreach(JournalEntry entry in _entries)
            {
                outputFile.WriteLine(entry.CreateFileSystemString());
            }
        }
    }


    public void ReadFromFile(string filename)
    {
        _entries.Clear();
        foreach (string line in File.ReadAllLines(filename))
        {
            string[] parts = line.Split("#");
            _entries.Add(new JournalEntry(parts[0], parts[1], parts[2]));
        }
    }


}