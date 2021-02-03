using System;
using System.Collections.Generic;
using System.Text;
using Alphabet;

namespace ViginereEncryption
{
    public static class ViginereEncyptor
    {
        const int LettersCount = 26;

        public static string Cipher(string keyword, string input)
        {
            if ((keyword == string.Empty) || (keyword == null) ||
                (input == string.Empty) || (keyword == null))
                throw new ArgumentException();

            StringBuilder retStrBuilder = new StringBuilder();
            int[] kWDgtlRprsntn = GetKeywordDigitalRepresentation(keyword, input.Length);

            for (int i = 0; i < input.Length; i++)
            {
                string letter = AlphabetService.GetCharacterFromIndex(
                    ((AlphabetService.GetIndexFromCharacter(input[i].ToString()) + kWDgtlRprsntn[i]) - 1) % LettersCount);
                retStrBuilder.Append(letter);
            }

            return retStrBuilder.ToString();
        }

        public static string Decipher(string keyword, string input)
        {
            if ((keyword == string.Empty) || (keyword == null) ||
                (input == string.Empty) || (keyword == null))
                throw new ArgumentException();

            StringBuilder retStrBuilder = new StringBuilder();
            int[] kWDgtlRprsntn = GetKeywordDigitalRepresentation(keyword, input.Length);

            for (int i = 0; i < input.Length; i++)
            {
                int index = (AlphabetService.GetIndexFromCharacter(input[i].ToString()) - kWDgtlRprsntn[i] + LettersCount) % LettersCount;
                string letter = AlphabetService.GetCharacterFromIndex(index + 1);
                retStrBuilder.Append(letter);
            }

            return retStrBuilder.ToString();
        }

        private static int[] GetKeywordDigitalRepresentation(string keyword, int requiredLength)
        {
            int[] retVal = new int[requiredLength];

            for (int i = 0; i < requiredLength; i++)
            {
                int j = i;
                if (j >= keyword.Length)
                    j %= keyword.Length;
                retVal[i] = AlphabetService.GetIndexFromCharacter(keyword[j].ToString());
            }

            return retVal;
        }

    }
}
