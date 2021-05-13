namespace Laba_5
{
	internal class Car : ICar
	{
		public EngineType EngineType { get; set; }

		public TransmissionType TransmissionType { get; set; }

		public int SeatsCount { get; set; }

		public override string ToString()
		{
			return $"Тип двигателя:{EngineType}\n" +
					$"Тип трансмиссии:{TransmissionType}\n" +
					$"Количество сидений:{SeatsCount}\n";
		}
	}
}
