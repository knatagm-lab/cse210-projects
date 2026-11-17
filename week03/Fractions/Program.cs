using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Console.WriteLine($"Fraction 1: {fraction1.GetFractionString()}");

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine($"Fraction 2: {fraction2.GetFractionString()}");
    
        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine($"Fraction 3: {fraction3.GetFractionString()}");

        Console.WriteLine("Decimal 1: " + fraction1.GetDecimalValue());
        Console.WriteLine("Decimal 2: " + fraction2.GetDecimalValue());
        Console.WriteLine("Decimal 3: " + fraction3.GetDecimalValue());
    
        Console.WriteLine("Numerator: " + fraction3.GetTop());
        Console.WriteLine("Denominator: " + fraction3.GetBottom());
    
        fraction3.SetTop(8);
        fraction3.SetBottom(2);

        Console.WriteLine($"Updated Fraction 3: {fraction3.GetFractionString()}");
    }

}