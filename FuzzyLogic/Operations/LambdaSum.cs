using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyLogic.Operations
{
    public class LambdaSum : ITernaryOperation
    {
        public double Operate(double operand1, double operand2, double operand3) => operand1 * operand2 + (1 - operand1) * operand3;
    }
}
