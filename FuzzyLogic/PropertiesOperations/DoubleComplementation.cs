using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuzzyLogic.Operations;
using FuzzyLogic.Sets;

namespace FuzzyLogic.PropertiesOperations
{
    public class DoubleComplementation : IUnaryProperty
    {
        public bool Operate(Set set) => Operation.Complementation(Operation.Complementation(set).Result).Result.Equals(set);
    }
}
