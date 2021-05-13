namespace Laba_5
{
	public interface ICar
	{
		EngineType EngineType { get; set; }
		TransmissionType TransmissionType { get; set; }
		int SeatsCount { get; set; }
	}
}
