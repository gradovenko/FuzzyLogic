using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyLogic.Operations
{
    public class Power : IBinaryOperation
    {
        public double Operate(double operand1, double operand2) => Math.Pow(operand1, operand2);
    }
}
