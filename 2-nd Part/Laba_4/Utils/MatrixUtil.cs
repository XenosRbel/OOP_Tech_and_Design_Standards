using System;

namespace Laba_4.Utils
{
	public static class MatrixUtil
	{
		public static string ConvertToString<T>(this T[,] matrix)
		{
			var result = string.Empty;

			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					result += matrix[i, j].ToString();
				}
			}

			return result;
		}
		public static T[,] ConvertToMatrix<T>(this T[] arr, int m, int n)
		{
			if (arr.Length != m * n)
			{
				throw new ArgumentNullException();
			}

			T[,] matrix = new T[m, n];
			Buffer.BlockCopy(arr, 0, matrix, 0, arr.Length * sizeof(char));
			return matrix;
		}
	}
	
}
