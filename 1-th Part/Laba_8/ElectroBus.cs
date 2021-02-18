using Laba_5;

namespace Laba_8
{
    internal abstract class ElectroBus : Bus
    {
        public override string ToString()
        {
            return $"{Name}\t{Color}\t{Type}\t{Power}";
        }
    }
}
