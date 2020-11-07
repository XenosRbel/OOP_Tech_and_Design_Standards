namespace Laba_6
{
    internal class Economy : ITaxi
    {
        public Economy(byte speed, float price, byte fuelVolume)
        {
            Speed = speed;
            Price = price;
            FuelVolume = fuelVolume;
        }

        public byte Speed { get; set; }
        public float Price { get; set; }
        public byte FuelVolume { get; set; }

        public override string ToString()
        {
            return $"Скорость:\t{Speed}\tЦена поездки:\t{Price}\tОбъем топлива:\t{FuelVolume}";
        }
    }
}
