namespace Laba_5
{
	public class Director
	{
		private IBuilder _builder;

		public IBuilder Builder { get => _builder; set => _builder = value; }

		public void BuildCarWithEngineAndTransmission()
		{
			this._builder.SetEngine();
			this._builder.SetTransmission();
		}

		public void BuildFullCar()
		{
			this._builder.SetEngine();
			this._builder.SetSeat();
			this._builder.SetTransmission();
		}
	}
}
