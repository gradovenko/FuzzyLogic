using System;

namespace FuzzyLogic.Operations
{
    public class Intersection : IBinaryOperation
    {
        public double Operate(double operand1, double operand2) => Math.Min(operand1, operand2);
    }
}
