using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your percentage? ");
        string percentage = Console.ReadLine();
        int percentageValue = int.Parse(percentage);

        string letterGrade = "";

        if (percentageValue >= 90)
        {
            letterGrade = "A";
        }
        else if (percentageValue >= 80)
        {
            letterGrade = "B";
        }
        else if (percentageValue >= 70)
        {
            letterGrade = "C";
        }
        else if (percentageValue >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        Console.WriteLine($"Your grade is: {letterGrade}");

        if (percentageValue >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}