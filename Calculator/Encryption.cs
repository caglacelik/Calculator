using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public class Encryption
    {
        private char[] _alphabet = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        public void ChangeAlphabet(string alphabet)
        {
            _alphabet = alphabet.ToUpper().ToCharArray().Distinct().ToArray();
        }

        public bool AlphabetContains(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (!_alphabet.Contains(char.ToUpper(input[i])))
                {
                    return false;
                }
            }
            return true;
        }

        private char RotateChar(char c, int rotValue)
        {
            int i = FindLetterInAlphabet(c);

            if (i == -1)
            {
                return c;
            }

            while (rotValue < 0)
            {
                rotValue += _alphabet.Length;
            }

            char rotatedChar = _alphabet[(i + rotValue) % _alphabet.Length];

            if (char.IsLower(c))
                rotatedChar = char.ToLower(rotatedChar);

            return rotatedChar;
        }

        public string CeaserCipher(string input, int rotValue)
        {
            char[] inputArray = input.ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                inputArray[i] = RotateChar(input[i], rotValue);
            }

            return new string(inputArray);
        }

        //returns index of the char in alphabet
        private int FindLetterInAlphabet(char c)
        {
            for (int i = 0; i < _alphabet.Length; i++)
            {
                if (_alphabet[i] == char.ToUpper(c))
                {
                    return i;
                }
            }
            return -1;
        }

        public string VigenereCipher(string input, string key)
        {
            char[] inputArray = input.ToCharArray();
            int j = 0;

            for (int i = 0; i < input.Length; i++)
            {
                j %= key.Length;
                inputArray[i] = RotateChar(input[i], FindLetterInAlphabet(key[j])+1);
                j++;
            }
            return new string(inputArray);
        }

        public string VigenereDecipher(string input, string key)
        {
            char[] inputArray = input.ToCharArray();
            int j = 0;

            for (int i = 0; i < input.Length; i++)
            {
                j %= key.Length;
                inputArray[i] = RotateChar(input[i], -(FindLetterInAlphabet(key[j]) + 1));
                j++;
            }
            return new string(inputArray);
        }
    }
}
