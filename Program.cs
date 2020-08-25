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

            if (answer != secretNumber)
            {
                Console.Write("WRONG!! Guess again! ");
                answer = Console.ReadLine();
            }
            else
            {
                Console.Write("You got it! What, do you want a ribbon or something? Now get lost! ");
            }
        }

    }
}