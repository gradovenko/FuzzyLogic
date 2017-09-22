using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyLogic.Operations
{
    public class DrasticUnion : IBinaryOperation
    {
        public double Operate(double operand1, double operand2) => operand1.Equals(0) ? operand2 : operand2.Equals(0) ? operand1 : 1;
    }
}
