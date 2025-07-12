using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Journal
{
    public class Journal
    {
        public List<Entry> _entries = new List<Entry>();

        public void AddEntry(Entry entry)
        {
            _entries.Add(entry);
        }

        public void DisplayAll()
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
                Console.WriteLine();
            }
        }

        public void SaveToFile(string file)
        {
            using (StreamWriter outputFile = new StreamWriter(file))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry._date}|{entry._mood}|{entry._promptText}|{entry._entryText}");
                }
            }
            // Confirmation message
            Console.WriteLine("Journal saved successfully!");
        }

        public void LoadFromFile(string file)
        {
            if (File.Exists(file))
            {
                //_entries.Clear();
                string[] lines = File.ReadAllLines(file);

                foreach (string line in lines)
                {
                    string[] parts = line.Split("|");

                    if (parts.Length == 4)
                    {
                        Entry entry = new Entry
                        {
                            _date = parts[0],
                            _mood = parts[1],
                            _promptText = parts[2],
                            _entryText = parts[3]
                        };

                        _entries.Add(entry);
                    }
                }
                // Confirmation message
                Console.WriteLine($"Your journal have been loaded successfully! Total: {_entries.Count}");
            }
            else
            {
                // Advice message
                Console.WriteLine("Journal not found.");
            }
        }

        // CreateEntry method
        public void CreateEntry(PrompGenerator promptGenerator)
        {
            Entry entry = new Entry();
            entry._date = DateTime.Now.ToShortDateString();

            Console.Write("How are you feeling today? (ex. happy, sad, excited...) ");
            entry._mood = Console.ReadLine();
            
            entry._promptText = promptGenerator.GetRandomPrompt();
            Console.WriteLine(entry._promptText);
            entry._entryText = Console.ReadLine();
            _entries.Add(entry);
        }
    }
}