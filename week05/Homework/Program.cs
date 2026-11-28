using System;

class Program
{
    static void Main(string[] args)
    {
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "Causes of World War II");
        Console.WriteLine($"{writingAssignment.GetStudentName()} - {writingAssignment.GetTopic()}");
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}