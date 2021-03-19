namespace Laba_4
{
	// Конкретные продукты создаются соответствующими Конкретными Фабриками.
	class ConcreteProductA1 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product A1.";
        }
    }
}
