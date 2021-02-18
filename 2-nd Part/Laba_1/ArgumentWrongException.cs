using System;

namespace Laba_1
{
	[Serializable]
	internal class ArgumentWrongException : Exception
	{
		public ArgumentWrongException()
		{
		}

		public ArgumentWrongException(string message) : base(message)
		{
		}
	}
}