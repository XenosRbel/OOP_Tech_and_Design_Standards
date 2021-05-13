namespace Laba_5
{
	internal class AutomaticPetrolStandardBuilder : IBuilder
	{
		public ICar Car { get; private set; }

		public AutomaticPetrolStandardBuilder()
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
			Car.EngineType = EngineType.Petrol;
		}

		public void SetTransmission()
		{
			Car.TransmissionType = TransmissionType.Automatic;
		}
	}
}
