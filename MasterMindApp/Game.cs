using System;
using System.Linq;

namespace MasterMindApp
{
    public class Game
    {
        private char[] _answer = new char[SecretCode.SecretCodeLength];
        private const int MaxNumberOfAttempts = 10;
        public const string PlayAgainYes = "Y";

        public void HowToPlay()
        {
            //Instructions of the game
            Console.WriteLine($"\nThe objective of this game is to crack a {SecretCode.SecretCodeLength} digit code with the numbers from 1 to 6.");
            Console.WriteLine($"Be cautious, you only have {MaxNumberOfAttempts} attempts");
            Console.WriteLine("A correct digit in the correct spot will be respresented with a \"+\"");
            Console.WriteLine("A correct digit in the wrong spot will be respresented with a \"-\"");
            Console.WriteLine("A incorrect digit will be respresented with a ' ' (blank space)");
        }

        public string Play()
        {
            Console.WriteLine("\n\nGame start, good luck!");
            SecretCode sc = new SecretCode();
            EndGame endGame = new EndGame();
            var secretCode = sc.GenerateSecretCode();
            bool crackedCode = false;

            for (int i = 1; i <= MaxNumberOfAttempts; i++)
            {
                Console.WriteLine($"\nTurn: {i}");
                string guess = Console.ReadLine();

                //Checks to see if the length is the correct size
                if (!EqualsMaxLength(guess.Length))
                {
                    Console.WriteLine("\nEnter a 4 (four) digit number.");
                    continue;
                }

                //Checks to see if it is a valid digit
                if (HasLetters(guess))
                {
                    Console.WriteLine("\nOnly digits can be entered.");
                    continue;
                }

                //Turns the guess into an array
                var guessLst = guess.Select(c => int.Parse(c.ToString())).ToArray();

                for (int j = 0; j< SecretCode.SecretCodeLength; j++)
                {
                    if (guessLst[j] == secretCode[j])
                    {
                        //Add the + to the correct guessed number
                        _answer[j] = '+';
                    }
                    else
                    {
                        bool misplaced = false;
                        for (int k = 0; k < SecretCode.SecretCodeLength; k++)
                        {
                            if (j != k && guessLst[j] == secretCode[k])
                            {
                                //Determines if the digit is correct but in the wrong position
                                misplaced = true;
                                break;
                            }
                        }

                        //Places the "-" or "b" for number
                        _answer[j] = misplaced ? '-' : ' ';
                    }
                }

                Console.WriteLine(string.Join("", _answer));

                //Checks to see if the guess was correct
                crackedCode = endGame.CheckGuess(_answer);

                //exit loop if code is cracked
                if (crackedCode) break;
            }

            //Gets the game results
            return endGame.CheckResult(crackedCode);
        }

        public bool PlayAgain(string answer)
        {
            //Checks to see if "Y" was entered
            return answer == PlayAgainYes;
        }

        public bool EqualsMaxLength(int GuessLength)
        {
            //Checks to see if guess length = SecretCodeLength
            return GuessLength == SecretCode.SecretCodeLength;
        }

        public bool HasLetters(string Guess)
        {
            //Checks to see if guess is a number
            return !int.TryParse(Guess, out int number);
        }
    }
}
