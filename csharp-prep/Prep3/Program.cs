using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep3 World!");

        string replay = "no";



        do
        {

            // decalre magic number and guess initial variables
            int magicNumber;
            int guessNumber;

            int guesses = 0;

            // get magic number
            // Console.Write("What is the magic number? ");
            // magicNumber = int.Parse(Console.ReadLine());

            // generate random magic number
            Random randomGenerator = new Random();
            magicNumber = randomGenerator.Next(1, 100);

            do
            {

                // get guess number
                Console.Write("What is your guess? ");
                guessNumber = int.Parse(Console.ReadLine());
                guesses += 1;

                if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("Higher");
                }
            } while (guessNumber != magicNumber);

            Console.WriteLine("You guessed it!");
            Console.WriteLine($"You made {guesses} guesses.");


            Console.Write("Do you want to replay the game? ");
            replay = Console.ReadLine();
        } while (replay.ToLower().Equals("yes"));


    }
}