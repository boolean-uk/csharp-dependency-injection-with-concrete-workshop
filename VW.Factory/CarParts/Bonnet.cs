using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VW.Factory.CarParts
{
    public class Bonnet
    {
        string _raceNumber;
        public Bonnet()
        {
            Console.WriteLine("Constructing a plain bonnet");
        }
        public Bonnet(string raceNumber)
        {
            Console.WriteLine("Constructing a custom sports bonnet");
            _raceNumber = raceNumber;
            
        }

        public string RaceNumber { get { return _raceNumber; } }
    }
}
