using System;
using System.Collections.Generic;
using Laba_4.Cryptos;

namespace Laba_4
{
	internal class Program
	{
		private static void Main()
		{
			var message = "колобок";

			ICryptAlgorithmFactory factory = new CryptAlgorithmFactory();

			var algorithms = new List<ICrypt>
			{
				factory.CreateMagicSquare(),
				factory.CreatePolibSquare(),
				factory.CreateWheatstoneSquare()
			};

			foreach (var algorithm in algorithms)
			{
				DemoCryptAlgorithm(algorithm, message);	
			}
		}

		private static void DemoCryptAlgorithm(ICrypt algorithm, string message)
		{
			var encryptMessage = algorithm.Crypt(message);
			var decryptedMessage = algorithm.Decrypt(encryptMessage);
			Console.WriteLine(encryptMessage);
			Console.WriteLine(decryptedMessage);
			Console.WriteLine();
		}
	}
}
