using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyLogic.Operations
{
    public class DisjunctionSum : IBinaryOperation
    {
        public double Operate(double operand1, double operand2) => Math.Max(Math.Min(operand1, 1 - operand2), 
            Math.Min(1 - operand1, operand2));
    }
}
