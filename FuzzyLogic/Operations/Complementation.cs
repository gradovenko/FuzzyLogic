using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyLogic.Operations
{
    public class Complementation : IUnaryOperations
    {
        public double Operate(double operand) => 1 - operand;
    }
}
