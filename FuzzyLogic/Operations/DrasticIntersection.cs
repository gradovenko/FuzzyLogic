using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyLogic.Operations
{
    public class DrasticIntersection : IBinaryOperation
    {
        public double Operate(double operand1, double operand2) => operand1.Equals(1) ? operand2 : operand2.Equals(1) ? operand1 : 0;
    }
}
