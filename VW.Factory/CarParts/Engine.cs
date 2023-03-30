using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VW.Factory.CarParts
{
    public class Engine
    {
        public Engine()
        {
            Console.WriteLine("Constructed engine with no parts?!");
        }
        public Engine(DieselEngineParts dieselEngineParts)
        {
            Console.WriteLine("Constructed diesel engine");
        }
        public Engine(ElectricEngineParts electricEngineParts)
        {
            Console.WriteLine("Constructed electric engine");
        }
        public Engine(PetrolEngineParts petrolEngineParts)
        {
            Console.WriteLine("Constructed petrol engine");
        }

    }
}
