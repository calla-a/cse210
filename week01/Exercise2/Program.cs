using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);
        string letter;
        int lastDigit = grade % 10;
        string sign;
        // determine grade letter
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80 && grade < 90)
        {
            letter = "B";
        }
        else if (grade >= 70 && grade < 80)
        {
            letter = "C";
        }
        else if (grade >= 60 && grade < 70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine();
        
        // plus or minus grade
        if (lastDigit >= 7 && !(grade >= 97))
        {
            sign = "+";
        }
        else if (lastDigit <= 3 && !(grade <= 59))
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // determine if the user passed the course
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations!!! You have passed the course");
        }
        else
        {
            Console.WriteLine("Unfortunately, you have not passed the course, but you can take it the following semester for half the cost.");
        }
    }
}