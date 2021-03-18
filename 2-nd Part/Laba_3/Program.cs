using System;
using System.Threading;

namespace Laba_3
{
	class Program
	{
		static void Main(string[] args)
		{
			var wheatstoneСipher = new WheatstoneСipher();

			var thread = new Thread(() => { Cr(wheatstoneСipher, 0); });
			var thread2 = new Thread(() => { Cr(wheatstoneСipher, 1000); });

			thread.Start();
			thread2.Start();
			Console.WriteLine("[1]:decrypt or encrypt\n[2]:Your string");

			Console.WriteLine("Press any key for close.");
			Console.ReadKey();

		}

		private static void Cr(WheatstoneСipher wheatstoneСipher, int sleepTime)
		{
			var userString = "hellol";

			var result = wheatstoneСipher.Encrypt(userString);
			Console.WriteLine(result);

			Thread.Sleep(sleepTime);

			result = wheatstoneСipher.Decrypt(result);
			Console.WriteLine(result);
		}
	}
}
