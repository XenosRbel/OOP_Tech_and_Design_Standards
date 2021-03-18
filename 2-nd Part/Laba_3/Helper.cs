using System;
using System.Linq;
using System.Threading;

namespace Laba_3
{
	public static class Helper
	{
		public static char[,] ConvertToMatrix(this char[] arr, int m, int n)
		{
			if (arr.Length != m * n)
			{
				throw new ArgumentNullException();
			}

			char[,] matrix = new char[m, n];
			Buffer.BlockCopy(arr, 0, matrix, 0, arr.Length * sizeof(char));
			return matrix;
		}

		public static char[] Shuffle(this char[] arr)
		{
			var rnd = new Random(DateTime.Now.Millisecond + Thread.CurrentThread.ManagedThreadId);

			return arr.OrderBy(item => rnd.Next()).ToArray();
		}

		public static char[,] FiilByMN(this char[,] m, int M, int N)
		{
			var matrix = new char[M, N];

			for (int i = 0; i < M; i++)
			{
				for (int j = 0; j < N; j++)
				{
					matrix[i, j] = m[i, j];
				}
			}

			return matrix;
		}
	}
}
