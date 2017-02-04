using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleFactory.Autos;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            string carName = args[0];

            AutoFactory factory = new AutoFactory();

            IAuto car = factory.CreateInstance(carName);

            car.TurnOn();
            car.TurnOff();
        }
    }
}
