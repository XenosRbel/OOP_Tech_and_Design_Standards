namespace Laba_4.Cryptos
{
	public interface ICrypt
	{
		string Crypt(string text);
		string Decrypt(string encryptText);
	}
}
