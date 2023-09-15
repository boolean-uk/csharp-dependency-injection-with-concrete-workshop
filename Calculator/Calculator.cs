using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        private Adding _adding;
        private Subtract _subtracting;

        public Calculator(Adding adding, Subtract subtracting)
        {
            _adding = adding;
            _subtracting = subtracting;

        }
        public Calculator(Adding adding)
        {
            _adding = adding;            

        }
        public int Calculate(int a, int b)
        {
            int result = 0;

            result = _adding.Add(a, b);

            return result;

        }

    }
}
