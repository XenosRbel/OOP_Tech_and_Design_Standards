using System;
using System.Collections.Generic;

namespace Laba_5
{
	class Program
	{
		static void Main(string[] args)
		{
			var director = new Director();

			var builders = new List<IBuilder>
			{
				new AutomaticPetrolStandardBuilder(),
				new MechanicalDiselStandardBuilder()
			};

			foreach (var builder in builders)
			{
				director.Builder = builder;
				director.BuildCarWithEngineAndTransmission();
				director.BuildFullCar();

				Console.WriteLine(director.Builder.Car);
			}
		}
	}
}
