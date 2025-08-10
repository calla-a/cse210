using System;
using Microsoft.VisualBasic;
using System.Threading.Tasks;
using System.Security.AccessControl;
using Mindfulness;

// Now, for the reflecting and listing activities repeated prompts and questions won't be selected until
// they all had been displayed at leat one time.
// The number of times that the activities were perfomed in the sesion will be showed to the user when
// the program finishes.

class Program
{
    static void Main(string[] args)
    {
        string userChoice;
        // this variables will track the number of times that a task is perfomed
        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;
        // one objecto of each one of this classes has to be created when the program starts, so that
        // the logic to not use repited prompts and questions works
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        ListingActivity listingActivity = new ListingActivity();
        Console.Clear();
        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listing activity");
            Console.WriteLine("   4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
                breathingCount++;
            }

            else if (userChoice == "2")
            {
                reflectingActivity.Run();
                reflectingCount++;
            }
            else if (userChoice == "3")
            {
                listingActivity.Run();
                listingCount++;
            }
            else if (userChoice != "4")
            {
                Console.WriteLine();
                Console.WriteLine("Please, select a valid option.");
            }
        } while (userChoice != "4");
        ActivityCounter(breathingCount, "Breating Activity");
        ActivityCounter(reflectingCount, "Reflecting Activity");
        ActivityCounter(listingCount, "Listing Activity");
    }

    // this method will show the number of times that an activity was perfomed, as long
    // as the activity was performed at least one time. Otherwise, nothing will be desplayed
    public static void ActivityCounter(int count, string activity)
    {
        if (count > 0)
        {
            if (count == 1)
            {
                Console.WriteLine($"You completed the {activity} {count} time.");
            }
            else
            {
                Console.WriteLine($"You have comleted the {activity} {count} times.");
            }
        }
    }
}