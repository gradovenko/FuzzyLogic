using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuzzyLogic.Operations;
using FuzzyLogic.Sets;

namespace FuzzyLogic.PropertiesOperations
{
    public class IdempotencyIntersection : IUnaryProperty
    {
        public bool Operate(Set set) => Operation.Intersection(set, set).Result.Equals(set);
    }
}
