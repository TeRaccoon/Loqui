using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loqui
{
    class Encryption
    {
        int[] numberEquivalent;

        public string Encrypt(int key1, int key2, int key3, string submittedText)
        {
            numberEquivalent = new int[submittedText.Length];
            string alphabet = "JpuAQc'hPCDoit;Ir!VfON*YRnmUxaWZEzgX.HsMeSBkdKF,vlGTLj:qwb?y1234567890@";
            char[] output = new char[submittedText.Length];
            int[] capital = new int[submittedText.Length];
            string outputText = "";

            for (int i = 0; i < submittedText.Length; i++)
            {
                numberEquivalent[i] = alphabet.IndexOf(submittedText[i]);
            }

            for (int i = 0; i < submittedText.Length; i++)
            {
                try
                {
                    numberEquivalent[i] = numberEquivalent[i] + Convert.ToInt32(key1);
                    SpaceCheckEncrypt(numberEquivalent[i], Convert.ToInt32(key1), i);
                    i++;
                    numberEquivalent[i] = numberEquivalent[i] + Convert.ToInt32(key2);
                    SpaceCheckEncrypt(numberEquivalent[i], Convert.ToInt32(key2), i);
                    i++;
                    numberEquivalent[i] = numberEquivalent[i] + Convert.ToInt32(key3);
                    SpaceCheckEncrypt(numberEquivalent[i], Convert.ToInt32(key3), i);
                }
                catch
                {
                    i = submittedText.Length;
                }
            }
            for (int i = 0; i < submittedText.Length; i++)
            {
                if (numberEquivalent[i] > alphabet.Length - 1)
                {
                    numberEquivalent[i] = numberEquivalent[i] - alphabet.Length;
                }
                try
                {
                    if (capital[i] == 0)
                    {
                        output[i] = alphabet[numberEquivalent[i]];
                    }
                    else
                    {
                        output[i] = alphabet[numberEquivalent[i]];
                    }
                }
                catch
                {
                    output[i] = submittedText[i];
                }
                outputText = new string(output);
            }
            outputText = Scramble(outputText);

            return outputText;
        }
        public string Scramble(string output)
        {
            char[] newOutput = output.ToCharArray();
            char reserve;
            for (int i = 0; i < output.Length; i++)
            {
                try
                {
                    reserve = output[i];
                    newOutput[i] = output[i + 1];
                    newOutput[i + 1] = reserve;
                    i++;
                }
                catch
                {
                    i = output.Length;
                }
            }
            output = new string(newOutput);
            return output;
        }
        public string Unscramble(string output)
        {
            char[] newOutput = output.ToCharArray();
            char reserve;
            for (int i = 0; i < output.Length; i++)
            {
                try
                {
                    reserve = output[i + 1];
                    newOutput[i + 1] = output[i];
                    newOutput[i] = reserve;
                    i++;
                }
                catch
                {
                    i = output.Length;
                }
            }
            output = new string(newOutput);
            return output;
        }
        public string Decrypt(int key1, int key2, int key3, string submittedText)
        {
            numberEquivalent = new int[submittedText.Length];
            string alphabet = "JpuAQc'hPCDoit;Ir!VfON*YRnmUxaWZEzgX.HsMeSBkdKF,vlGTLj:qwb?y1234567890@";
            char[] output = new char[submittedText.Length];
            int[] capital = new int[submittedText.Length];
            string outputText = "";
            submittedText = Unscramble(submittedText);
            int alphabetLength = alphabet.Length;

            for (int i = 0; i < submittedText.Length; i++)
            {
                numberEquivalent[i] = alphabet.IndexOf(submittedText[i]);
            }

            for (int i = 0; i < submittedText.Length; i++)
            {
                try
                {
                    numberEquivalent[i] = numberEquivalent[i] - Convert.ToInt32(key1);
                    SpaceCheckDecrypt(numberEquivalent[i], Convert.ToInt32(key1), i, alphabetLength);
                    i++;
                    numberEquivalent[i] = numberEquivalent[i] - Convert.ToInt32(key2);
                    SpaceCheckDecrypt(numberEquivalent[i], Convert.ToInt32(key2), i, alphabetLength);
                    i++;
                    numberEquivalent[i] = numberEquivalent[i] - Convert.ToInt32(key3);
                    SpaceCheckDecrypt(numberEquivalent[i], Convert.ToInt32(key3), i, alphabetLength);
                }
                catch
                {
                    i = submittedText.Length;
                }
            }

            for (int i = 0; i < submittedText.Length; i++)
            {
                if (numberEquivalent[i] < 0)
                {
                    numberEquivalent[i] = numberEquivalent[i] + alphabet.Length;
                }
                try
                {
                    if (capital[i] == 0)
                    {
                        output[i] = alphabet[numberEquivalent[i]];
                    }
                    else
                    {
                        output[i] = alphabet[numberEquivalent[i]];
                    }
                }
                catch
                {
                    output[i] = submittedText[i];
                }
                outputText = new string(output);
            }

            submittedText = submittedText.Substring(submittedText.Length);

            return outputText + submittedText;
        }
        public void SpaceCheckEncrypt(int checkIndex, int key, int index)
        {
            if (checkIndex - key == -1)
            {
                numberEquivalent[index] = -1;
            }
        }
        public void SpaceCheckDecrypt(int checkIndex, int key, int index, int alphaLength)
        {
            if (checkIndex + key == -1)
            {
                numberEquivalent[index] = alphaLength;
            }
        }
    }
}
