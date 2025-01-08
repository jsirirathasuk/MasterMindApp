using MasterMindApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class SecretCodeTest
    {
        [TestMethod]
        [DataRow(SecretCode.SecretCodeLength)]
        public void GenerateSecretCodeLengthReturnTrue(int val)
        {
            //Arrange
            var secretCode = new SecretCode();

            //Act
            var result = secretCode.GenerateSecretCode();

            //Assert
            Assert.AreEqual(val, result.Length);
        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(10)]
        [DataRow(100)]
        public void GenerateSecretCodeLengthReturnFalse(int val)
        {
            //Arrange
            var secretCode = new SecretCode();

            //Act
            var result = secretCode.GenerateSecretCode();

            //Assert
            Assert.AreNotEqual(val, result.Length);
        }
    }
}
