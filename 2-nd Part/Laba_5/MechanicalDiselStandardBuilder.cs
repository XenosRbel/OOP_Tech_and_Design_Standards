namespace Laba_5
{
	internal class MechanicalDiselStandardBuilder : IBuilder
	{
		public ICar Car { get; private set; }

		public MechanicalDiselStandardBuilder()
		{
			Car = new Car();
		}

		public void Reset()
		{
			Car = new Car();
		}

		public void SetSeat()
		{
			Car.SeatsCount = 4;
		}

		public void SetEngine()
		{
			Car.EngineType = EngineType.Disel;
		}

		public void SetTransmission()
		{
			Car.TransmissionType = TransmissionType.Mechanical;
		}
	}
}
