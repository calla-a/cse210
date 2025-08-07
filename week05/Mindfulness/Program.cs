using System;
using Microsoft.VisualBasic;
using System.Threading.Tasks;
using System.Security.AccessControl;
using Mindfulness;


class Program
{
    static void Main(string[] args)
    {
        int userChoice;

        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listing activity");
            Console.WriteLine("   4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity",
                    "relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing");
                breathingActivity.Run();
            }

            else if (userChoice == 2)
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity",
                    "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life");
            }
        } while (userChoice != 4);
    }
}