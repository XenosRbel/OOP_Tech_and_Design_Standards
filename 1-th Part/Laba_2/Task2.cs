using System;

namespace Laba_2
{
    public class Task2
    {
        public void Execute()
        {
            var matrix = RandomFillMatrix(3, 3, -3, 3);

            PrintSum(matrix);
        }

        public static int[,] RandomFillMatrix(int n, int m, int minValue, int maxValue)
        {
            var res = new int[n, m];
            var rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    res[i, j] = rnd.Next(minValue, maxValue);
                }
            }

            return res;
        }

        public void PrintSum(int[,] matrix)
        {
            var sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}\t");

                    if (matrix[i, i] < 0)
                        sum += matrix[i, j];
                }

                if (matrix[i, i] < 0)
                {
                    Console.WriteLine($"Сумма строки == {sum}");
                }

                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
