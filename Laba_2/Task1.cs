using System.Linq;

namespace Laba_2
{
    public class Task1
    {
        public void Execute()
        {
            var array = Enumerable.Range(1, 10);
            var result = array.Select((value, index) => (index + 1).IsEven() ? value * (-1) : value);

            result.Print();
        }
    }
}
