using VW.Factory.CarParts;
using VW.Factory.Cars;

namespace VW.Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //car production line

            ElectricEngine engine = new ElectricEngine();
            Beetle beetle = new Beetle(engine);
            
            beetle.accelerate();

            Console.ReadLine();

        }
    }
}