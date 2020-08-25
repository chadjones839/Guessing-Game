using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GuessNumber();
        }

        static void GuessNumber()
        {
            Console.Write("Guess the Secret Number!! ---> ");
            string answerString = Console.ReadLine();
            int answer = Int32.Parse(answerString);
            int secretNumber = new Random().Next(1,100);
            int count = 0;
            int countdown = 4;

            while (answer != secretNumber && ++count < 4)
            {
            if (answer != secretNumber)
                Console.Write("WRONG!! ");
                Console.Write(answer);
                Console.Write($" isn't even close! You have {--countdown} guesses left!");
                Console.WriteLine();
                Console.Write("Guess Again ---> ");
                answerString = Console.ReadLine();
                Console.WriteLine();

                answer = Int32.Parse(answerString);
            }
            if (answer == secretNumber)
            {
                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine();
                Console.Write("You got it! What, do you want a ribbon or something? Now get lost! ");
            }
            else
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("YOU BLEW IT, TURKEY!");
                Console.WriteLine();
                Console.WriteLine($"--> The answer was {secretNumber} <--");
                Console.WriteLine();
                Console.WriteLine(@"""Nobody likes a sore loser.""");
                Console.WriteLine("               -Abraham Lincoln");
            }
        }

    }
}