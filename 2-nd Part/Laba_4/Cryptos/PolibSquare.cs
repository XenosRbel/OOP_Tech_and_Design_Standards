namespace Laba_4.Cryptos
{
	/// <summary>
	/// Квадрат Полибия
	/// </summary>
	internal class PolibSquare : ICrypt
    {
        /// <summary>
        /// Таблица шифрования
        /// </summary>
        private readonly char[,] arr;
        private const int ArrLenght = 6;

        public PolibSquare()
        {
            arr = new char[ArrLenght, ArrLenght];
            FillArrayByAlphabet();
        }

        public string Crypt(string text)
        {
            return this.Encrypt(text);
        }

        /// <summary>
        /// Заполнить таблицу шифрования по алфавиту
        /// </summary>
        public void FillArrayByAlphabet()
        {
            char letter = 'а';

            for (int i = 0; i < ArrLenght; i++)
            {
                for (int j = 0; j < ArrLenght; j++)
                {
                    arr[i, j] = letter;

                    if (letter == 'я')
                        break;
                    letter++;
                }
            }
        }

        /// <summary>
        /// Первый вариант шифрования
        /// Находим буву в таблице и вместо неё записываем нижнюю от неё в этом же столбце
        /// Если буква была в нижней строчке, берём из первой
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string Encrypt(string str)
        {
            string result = null;

            if (!CheckString(str))
                return "В строке присутсвуют запрещенные символы";

            foreach (var letter in str.ToLower()) // берём букву из строки
            {
                if (letter == ' ') // пробел просто добавляем в резалт строку
                {
                    result += letter;
                    continue;
                }

                for (int i = 0; i < ArrLenght; i++)
                {
                    for (int j = 0; j < ArrLenght; j++)
                    {
                        if (letter == arr[i, j]) // находим нужную букву в таблице
                        {
                            if (i == ArrLenght - 1 || arr[i + 1, j] == '\0') // если буква из последней строки или под ней пусто берём букву из первой строки
                                result += arr[0, j];
                            else
                                result += arr[i + 1, j]; // иначе просто из нижней строки
                        }
                    }
                }
            }

            return result;
        }

        public string Decrypt(string str) // все тоже самое что в Encrypt только наоборот
        {
            string result = null;

            if (!CheckString(str))
                return "В строке присутсвуют запрещенные символы";

            foreach (var letter in str.ToLower())
            {
                if (letter == ' ')
                {
                    result += letter;
                    continue;
                }

                for (int i = 0; i < ArrLenght; i++)
                {
                    for (int j = 0; j < ArrLenght; j++)
                    {
                        if (letter == arr[i, j])
                        {
                            if (i == 0)
                            {
                                if (arr[ArrLenght - 1, j] == '\0')
                                    result += arr[ArrLenght - 2, j];
                                else result += arr[ArrLenght - 1, j];
                            }
                            else
                                result += arr[i - 1, j];
                        }
                    }
                }
            }

            return result;
        }

        private bool CheckString(string str) // проверить строку на правильность ввода
        {
            foreach (var letter in str.ToLower())
            {
                if (!(letter >= 'а' && letter <= 'я' || letter == ' '))
                    return false;
            }

            return true;
        }
	}
}
