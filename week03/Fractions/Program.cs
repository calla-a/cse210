using System;
using Fractions;

class Program
{
    static void Main(string[] args)
    {
        HoldFraction fraction = new HoldFraction();
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());

        HoldFraction fraction1 = new HoldFraction(5);
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        HoldFraction fraction2 = new HoldFraction(3, 4);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        HoldFraction fraction3 = new HoldFraction(1, 3);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());
    }
}