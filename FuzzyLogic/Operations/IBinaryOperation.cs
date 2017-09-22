using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyLogic.Operations
{
    public interface IBinaryOperation : IOperation
    {
        double Operate(double operand1, double operand2);
    }
}
