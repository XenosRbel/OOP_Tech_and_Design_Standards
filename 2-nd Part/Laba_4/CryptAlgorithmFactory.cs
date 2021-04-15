using Laba_4.Cryptos;

namespace Laba_4
{
	internal class CryptAlgorithmFactory : ICryptAlgorithmFactory
	{
		public ICrypt CreateMagicSquare()
		{
			return new MagicSquare();
		}

		public ICrypt CreatePolibSquare()
		{
			return new PolibSquare();
		}

		public ICrypt CreateWheatstoneSquare()
		{
			return new WheatstoneSquare();
		}
	}
}
