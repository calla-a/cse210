using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Journal
{
    public class Entry
    {
        public string _date;
        public string _promptText;
        public string _entryText;
        // mood attribute
        public string _mood;

        public void Display()
        {
            Console.WriteLine($"Date: {_date} - My mood: {_mood}");
            Console.WriteLine($"Prompt: {_promptText}");
            Console.WriteLine(_entryText);
        }
    }
}