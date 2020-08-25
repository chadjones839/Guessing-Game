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
            Console.Write("Guess the Secret Number!! ");
            string answer = Console.ReadLine();
            string secretNumber = "42";
            int count = 0;

            while (answer != secretNumber && ++count < 4)
            {
                Console.Write("WRONG!! Guess again! ");
                answer = Console.ReadLine();
            }
            if (answer == secretNumber)
            {
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine();
                Console.Write("You got it! What, do you want a ribbon or something? Now get lost! ");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("---------------------------------");
                Console.WriteLine("YOU BLEW IT, TURKEY!");
                Console.WriteLine();
                Console.WriteLine(@"""Nobody likes a sore loser.""");
                Console.WriteLine("            -Abraham Lincoln");
            }
        }

    }
}