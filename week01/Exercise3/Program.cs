using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("What is your magic number? ");
        //string magicNumber = Console.ReadLine();
        //int magicNumberValue = int.Parse(magicNumber);

        //int guess = 0;

        Random randomGenerator = new Random();
        int magicNumberValue = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != magicNumberValue)

        {
            Console.WriteLine("What is your guess? ");
            string guessInput = Console.ReadLine();
            guess = int.Parse(guessInput);

            if (magicNumberValue > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumberValue)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}