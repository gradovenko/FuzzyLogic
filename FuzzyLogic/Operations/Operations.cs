using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyLogic.Operations
{
    public class Operations
    {
        public static double Union(double operand1, double operand2) => new Union().Operate(operand1, operand2);
    }
}
