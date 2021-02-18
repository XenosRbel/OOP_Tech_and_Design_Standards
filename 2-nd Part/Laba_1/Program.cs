using System;

namespace Laba_1
{
	class Program
	{
		static void Main(string[] args)
		{
			var wheatstoneСipher = new WheatstoneСipher();

			var programParam = args[0].ToLower() ?? throw new ArgumentNullException("args");
			var userString = args[1] ?? throw new ArgumentNullException("args");

			try
			{
				MethodHandle(wheatstoneСipher, programParam, userString);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				Console.WriteLine("[1]: decrypt or encrypt\n[2]:Your string");
			}

			Console.WriteLine("Press any key for close.");
			Console.ReadKey();
		}

		private static void MethodHandle(WheatstoneСipher wheatstoneСipher, string programParam, string userString)
		{
			switch (programParam)
			{
				case "decrypt":
					var resutlDecrypt = wheatstoneСipher.Decrypt(userString);
					Console.WriteLine(resutlDecrypt);
					break;
				case "encrypt":
					var resultEncrypt = wheatstoneСipher.Encrypt(userString);
					Console.WriteLine(resultEncrypt);
					break;
				default:
					throw new ArgumentWrongException("Невеный порядок аргументов");
			}
		}
	}
}
