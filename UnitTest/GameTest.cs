using MasterMindApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        [DataRow(1)]
        [DataRow(10)]
        [DataRow(100)]
        [DataRow(10000)]
        public void EqualsMaxLengthReturnFalse(int val)
        {
            //Arrange
            var game = new Game();

            //Act
            var result = game.EqualsMaxLength(val);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        [DataRow(4)]
        public void EqualsMaxLengthReturnTrue(int val)
        {
            //Arrange
            var game = new Game();

            //Act
            var result = game.EqualsMaxLength(val);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow("a111")]
        [DataRow("aa11")]
        [DataRow("aaa1")]
        [DataRow("aaaa")]
        public void HasLettersReturnTrue(string val)
        {
            //Arrange
            var game = new Game();

            //Act
            var result = game.HasLetters(val);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow("1111")]
        [DataRow("1234")]
        public void HasLettersReturnFalse(string val)
        {
            //Arrange
            var game = new Game();

            //Act
            var result = game.HasLetters(val);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        [DataRow("Y")]
        public void PlayAgainReturnTrue(string val)
        {
            //Arrange
            var game = new Game();

            //Act
            var result = game.PlayAgain(val);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow("N")]
        public void PlayAgainReturnFalse(string val)
        {
            //Arrange
            var game = new Game();

            //Act
            var result = game.PlayAgain(val);

            //Assert
            Assert.IsFalse(result);
        }
    }
}
