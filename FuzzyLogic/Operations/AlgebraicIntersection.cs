using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyLogic.Operations
{
    public class AlgebraicIntersection : IBinaryOperation
    {
        public double Operate(double operand1, double operand2) => operand1 * operand2;
    }
}
