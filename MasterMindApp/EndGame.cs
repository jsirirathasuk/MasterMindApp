using System.Linq;

namespace MasterMindApp
{
    public class EndGame
    {
        public char[] _answer = new char[SecretCode.SecretCodeLength];
        private const string _win = "You cracked the code!";
        private const string _lose = "You didn't crack the code!";

        public bool CheckGuess(char[] Guess)
        {
            //Checks to see if the Guess was correct
            return Guess.All(x => x == '+');
        }
        
        public string CheckResult(bool CrackedCode)
        {
            //Returns the results of the game
            return CrackedCode ? _win : _lose;
        }
    }
}
