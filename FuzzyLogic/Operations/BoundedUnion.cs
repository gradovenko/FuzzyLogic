﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyLogic.Operations
{
    public class BoundedUnion : IBinaryOperation
    {
        public double Operate(double operand1, double operand2) => Math.Min(operand1 + operand2, 1);
    }
}
