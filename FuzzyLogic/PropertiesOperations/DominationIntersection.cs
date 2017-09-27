using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuzzyLogic.Operations;
using FuzzyLogic.Sets;

namespace FuzzyLogic.PropertiesOperations
{
    public class DominationIntersection : IUnaryProperty
    {
        public bool Operate(Set set) => Operation.Intersection(set, new Set(new List<double>())).Result.Equals(set);
    }
}
