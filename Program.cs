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
            Console.Write("You Guessed ");
            Console.Write(answer);
        }

    }
}