using Laba_4.Cryptos;

namespace Laba_4
{
	public interface ICryptAlgorithmFactory
	{
		ICrypt CreateMagicSquare();
		ICrypt CreatePolibSquare();
		ICrypt CreateWheatstoneSquare();
	}
}
