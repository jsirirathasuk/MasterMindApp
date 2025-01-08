using System;
using System.Collections.Generic;

namespace MasterMindApp
{
    class Program
    {
        private static List<string> _validAnswer = new List<string> { "Y", "N" };
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to the Mastermind game!");

            //Game is created for the player
            Game game = new Game();
            bool keepPlaying = true;

            game.HowToPlay();
            while (keepPlaying)
            {
                Console.WriteLine(game.Play());

                //Handles replayability
                Console.WriteLine("\nDo you want to play again?");
                Console.WriteLine("Y/N");
                string answer = Console.ReadLine().ToUpper();

                while (!_validAnswer.Contains(answer))
                {
                    Console.WriteLine("Enter a valid answer.");
                    answer = Console.ReadLine();
                }

                keepPlaying = game.PlayAgain(answer);
            }

            Console.WriteLine("\nThank you for playing Mastermind!");
            Console.Read();
        }
    }
}
