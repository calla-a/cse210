using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Mindfulness
{
    public class ListingActivity : Activity
    {
        private int _count;
        private List<string> _prompts;

        // new attributes created to select only prompts that haven't been selected
        private List<string> _avPrompts;
        private Random _randomElement = new Random();

        public ListingActivity() : base("Listing Activity",
                                        "reflect on the good things in your life by having you list as many things as you can in a certain area")
        {
            _prompts = new List<string>
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            };
            _avPrompts = new List<string>(_prompts);
        }

        public void Run()
        {
            DisplayStartingMessage();
            Console.WriteLine("List as many responses you can to the following prompt:");
            Console.WriteLine($" --- {GetRandomPrompt()} ---");
            Console.Write($"You may begin in: ");
            ShowCountDown(5);
            var userList = GetListFromUser();
            _count = userList.Count();
            Console.WriteLine($"You listed {_count} items!");
            Console.WriteLine();
            DisplayEndingMessage();
        }

        public string GetRandomPrompt()
        {
            if (_avPrompts.Count == 0)
            {
                _avPrompts = new List<string>(_prompts);
            }
            int index = _randomElement.Next(_avPrompts.Count);
            string selectedPrompt = _avPrompts[index];
            _avPrompts.RemoveAt(index);
            return selectedPrompt;
        }

        public List<string> GetListFromUser()
        {
            List<string> userList = new List<string>();
            string userInput;
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(GetDuration());
            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                userInput = Console.ReadLine();
                userList.Add(userInput);
            }
            return userList;
        }
    }
}