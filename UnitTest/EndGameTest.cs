using MasterMindApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class EndGameTest
    {
        private const string _win = "You cracked the code!";
        private const string _lose = "You didn't crack the code!";

        [TestMethod]
        public void CheckResultReturnTrueWin()
        {
            //Arrange
            var endGame = new EndGame();

            //Act
            var result = endGame.CheckResult(true);

            //Assert
            Assert.AreEqual(_win, result);
        }

        [TestMethod]
        public void CheckResultReturnFalseWin()
        {
            //Arrange
            var endGame = new EndGame();

            //Act
            var result = endGame.CheckResult(true);

            //Assert
            Assert.AreNotEqual(_lose, result);
        }

        [TestMethod]
        public void CheckResultReturnTrueLose()
        {
            //Arrange
            var endGame = new EndGame();

            //Act
            var result = endGame.CheckResult(false);

            //Assert
            Assert.AreEqual(_lose, result);
        }

        [TestMethod]
        public void CheckResultReturnFalseLose()
        {
            //Arrange
            var endGame = new EndGame();

            //Act
            var result = endGame.CheckResult(true);

            //Assert
            Assert.AreNotEqual(_lose, result);
        }

        [TestMethod]
        [DataRow(new char[] {'+', '+', '+', '+'})]
        public void CheckQuessReturnTrue(char[] val)
        {
            //Arrange
            var endGame = new EndGame();

            //Act
            var result = endGame.CheckGuess(val);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]

        [DataRow(new char[] { '+', '-', '+', '+' })]
        [DataRow(new char[] { '+', '-', '-', '+' })]
        [DataRow(new char[] { '+', '-', '-', '-' })]
        [DataRow(new char[] { '-', '-', '-', '-' })]
        [DataRow(new char[] { '+', ' ', '+', '+' })]
        public void CheckQuessReturnFalse(char[] val)
        {
            //Arrange
            var endGame = new EndGame();

            //Act
            var result = endGame.CheckGuess(val);

            //Assert
            Assert.IsFalse(result);
        }
    }
}
