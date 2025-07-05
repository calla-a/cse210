using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        string answer;
        int number;

        Console.Write("Enter number: ");
        answer = Console.ReadLine();
        while (!(answer == "0"))
        {
            number = int.Parse(answer);
            numbers.Add(number);

            Console.Write("Enter number: ");
            answer = Console.ReadLine();
        }

        int sum = 0;
        int largestNumber = 0;
        int smallestNumber = 100000;
        foreach (int integer in numbers)
        {
            sum = sum + integer;
            if (integer > largestNumber)
            {
                largestNumber = integer;
            }
            if (integer > 0 && integer < smallestNumber)
            {
                smallestNumber = integer;
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestNumber}");
        Console.WriteLine("The sorted list is:");

        numbers.Sort();
        foreach (int integer in numbers)
        {
            Console.WriteLine(integer);
        }
    }
}