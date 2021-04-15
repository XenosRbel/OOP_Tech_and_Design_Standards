using System;
using Laba_4.Utils;

namespace Laba_4.Cryptos
{
	internal class MagicSquare : ICrypt
    {
        private const int DefaultSquareSize = 4;

        public string Crypt(string text)
		{
            var crypted = this.EncryptionMagicSquare(text);
            return crypted.ConvertToString();
        }

        public string Decrypt(string text)
        {
            var cryptedMessage = text.ToCharArray().ConvertToMatrix(DefaultSquareSize, DefaultSquareSize);
            return this.DecipherMagicSquare(cryptedMessage);
        }

        private int[,] defaultSquare = new int[DefaultSquareSize, DefaultSquareSize] { { 16, 3, 2, 13 }, { 9, 6, 7, 12 }, { 5, 10, 11, 8 }, { 4, 15, 14, 1 } };

        private char[,] EncryptionMagicSquare(string text)
        {
            int index = 0;
            char[,] encryptedText = new char[4, 4] { { ' ', ' ', ' ', ' ' }, { ' ', ' ', ' ', ' ' }, { ' ', ' ', ' ', ' ' }, { ' ', ' ', ' ', ' ' } };
            while (index != text.Length)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if ((defaultSquare[i, j] == index + 1) && (index != text.Length))
                        {
                            encryptedText[i, j] = text[index];
                            index++;
                        }
                    }
                }

            }

            return encryptedText;
        }

        private string DecipherMagicSquare(char[,] text)
        {
            int index = 0;
            string decipheredText = null;
            while (index != text.Length)
            {
                for (int i = 0; i < text.GetLength(0); i++)
                {
                    for (int j = 0; j < text.GetLength(1); j++)
                    {
                        if ((defaultSquare[i, j] == index + 1) && (index != text.Length))
                        {
                            decipheredText += Convert.ToString(text[i, j]);
                            index++;
                        }
                    }
                }
            }
            return decipheredText;
        }
    }
}
