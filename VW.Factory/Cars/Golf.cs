using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VW.Factory.CarParts;

namespace VW.Factory.Cars
{
    public class Golf
    {
        private Engine _engine;
        public Golf(Engine engine)
        {
            _engine = engine;
        }
    }
}
