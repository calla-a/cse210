using System;
using Journal;

// Added mood as a new attribute of the Entry class. Now the user will be asked to register their mood when they write in the Journal
// The mood will be registered and saved with the other information
class Program
{
    static void Main(string[] args)
    {
        PrompGenerator promptGenerator = new PrompGenerator();
        promptGenerator.AddPrompt();
        Journal.Journal journal = new Journal.Journal();

        Console.WriteLine("Welcome to your Journal Program");
        Console.WriteLine("Please select one of the following options:");
        string answer;
        do
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            answer = Console.ReadLine();

            if (answer == "1")
            {
                journal.CreateEntry(promptGenerator);
            }
            else if (answer == "2")
            {
                journal.DisplayAll();
            }
            else if (answer == "3")
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
            }
            else if (answer == "4")
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            }
        } while (answer != "5");
    }
}