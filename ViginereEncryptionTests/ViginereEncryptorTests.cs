using System;
using Xunit;
using ViginereEncryption;

namespace ViginereEncryptionTests
{
    public class ViginereEncryptorTests
    {
        [Fact]
        public void CanCipher()
        {
            string input = "ATTACKATDAWN";
            string keyword = "LEMON";

            Assert.Equal("LXFOPVEFRNHR".ToLower(), ViginereEncyptor.Cipher(keyword, input));
        }

        [Fact]
        public void CanDecipher()
        {
            string input = "LXFOPVEFRNHR";
            string keyword = "LEMON";

            Assert.Equal("ATTACKATDAWN".ToLower(), ViginereEncyptor.Decipher(keyword, input));
        }
    }
}
