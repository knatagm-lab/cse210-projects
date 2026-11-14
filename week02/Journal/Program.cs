using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        PromptGenerator promptGenerator = new PromptGenerator();

        string choice = "";
        while (choice != "5")

        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);

                Console.WriteLine("Your response:");
                string entryText = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                Entry entry = new Entry(dateText, prompt, entryText);
                journal.AddEntry(entry);
                break;

            case "2":
                journal.DisplayAll();
                break;

            case "3":
                Console.WriteLine("Enter the filename to load:");
                string loadFilename = Console.ReadLine();
                journal.LoadFromFile(loadFilename);
                break;

            case "4":
                Console.WriteLine("Enter filename:");
                string saveFilename = Console.ReadLine();
                journal.SaveToFile(saveFilename);
                break;

            case "5":
                Console.WriteLine("Goodbye!");
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
    }
}