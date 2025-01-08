using System;

namespace MasterMindApp
{
    public class SecretCode
    {
        public const int SecretCodeLength = 4;
        public int[] _SecretCode = new int[SecretCodeLength];

        public int[] GenerateSecretCode()
        {
            //Generates the sercret code
            var ran = new Random();
            for (int i = 0; i < SecretCodeLength; i++)
            {
                _SecretCode[i] = ran.Next(1, 7);
            }

            return _SecretCode;
        }
    }
}
