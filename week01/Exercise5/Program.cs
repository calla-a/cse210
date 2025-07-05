using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();

        int favoriteNumber = PromtUserNumber();
        int squareNumber = SquareNumber(favoriteNumber);

        DisplayResult(userName, squareNumber);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromtUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string answer = Console.ReadLine();
            int userNumber = int.Parse(answer);
            return userNumber;
        }

        static int SquareNumber(int number)
        {
            int squareNumber = number * number;
            return squareNumber;
        }

        static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"{name}, the square of your number is {number}");
        }
    }
}