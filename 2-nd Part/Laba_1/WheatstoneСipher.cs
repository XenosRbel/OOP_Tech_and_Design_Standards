namespace Laba_1
{
	class WheatstoneСipher
    {
        private readonly char[,] _firstMatrix = new char[7, 5]
        {
          {'ж', 'щ', 'н', 'ю', 'р'},
          {'и', 'т', 'ь', 'ц', 'б'},
          {'я', 'м', 'е', '.', 'с'},
          {'в', 'ы', 'п', 'ч', ' '},
          {'й', 'д', 'у', 'о', 'к'},
          {'з', 'э', 'ф', 'г', 'ш'},
          {'х', 'а', ',', 'л', 'ъ'}
        };

        private readonly char[,] _secondMatrix = new char[7, 5]
        {
          {'и', 'ч', 'г', 'я', 'т'},
          {',', 'ж', 'м', 'ь', 'о'},
          {'з', 'ю', 'р', 'в', 'щ'},
          {'ц', 'й', 'п', 'е', 'л'},
          {'ъ', 'а', 'н', '.', 'х'},
          {'э', 'к', 'с', 'ш', 'д'},
          {'б', 'ф', 'у', 'ы', ' '}
        };

        public string Encrypt(string text)
        {
            text = text.ToLower();

            string result_text = "";

            if (text.Length % 2 != 0)
            {
                text += ' ';
            }
            int length = text.Length / 2;
            int k = 0;
            char[,] bigram = new char[length, 2];
            char[,] kripto_bigram = new char[length, 2];

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    bigram[i, j] = text[k];
                    k++;
                }
            }
            int step = 0;
            while (step < length)
            {
                var cortege1 = FindIndexes(bigram[step, 0], _firstMatrix);
                var cortege2 = FindIndexes(bigram[step, 1], _secondMatrix);

                kripto_bigram[step, 0] = _secondMatrix[(int)cortege1.i, (int)cortege2.j];
                kripto_bigram[step, 1] = _firstMatrix[(int)cortege2.i, (int)cortege1.j];

                step++;
            }


            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result_text += kripto_bigram[i, j].ToString();
                }
            }

            return result_text;
        }


        public string Decrypt(string text)
        {
            string result_text = "";

            int length = text.Length / 2;
            int k = 0;

            char[,] bigram = new char[length, 2];
            char[,] kripto_bigram = new char[length, 2];

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    bigram[i, j] = text[k];
                    k++;
                }
            }

            int step = 0;
            while (step < length)
            {
                var cortege1 = FindIndexes(bigram[step, 0], _secondMatrix);
                var cortege2 = FindIndexes(bigram[step, 1], _firstMatrix);

                kripto_bigram[step, 0] = _firstMatrix[(int)cortege1.i, (int)cortege2.j];
                kripto_bigram[step, 1] = _secondMatrix[(int)cortege2.i, (int)cortege1.j];

                step++;
            }


            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result_text += kripto_bigram[i, j].ToString();
                }
            }


            return result_text;
        }

        private (int? i, int? j) FindIndexes(char symbol, char[,] matrix)
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (symbol == matrix[i, j])
                    {
                        return (i, j);
                    }
                }
            }

            return (i: null, j: null);
        }
    }
}
