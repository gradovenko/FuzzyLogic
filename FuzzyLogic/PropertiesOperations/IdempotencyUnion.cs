using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuzzyLogic.Operations;
using FuzzyLogic.Sets;

namespace FuzzyLogic.PropertiesOperations
{
    public class IdempotencyUnion : IUnaryProperty
    {
        public bool Operate(Set set) => Operation.Union(set, set).Result.Equals(set);
    }
}
