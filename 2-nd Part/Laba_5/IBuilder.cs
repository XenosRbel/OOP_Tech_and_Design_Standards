namespace Laba_5
{
	public interface IBuilder
	{
		ICar Car { get; }
		void Reset();
		void SetSeat();
		void SetEngine();
		void SetTransmission();
	}
}
