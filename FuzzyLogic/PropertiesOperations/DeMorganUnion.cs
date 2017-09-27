using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuzzyLogic.Operations;
using FuzzyLogic.Sets;

namespace FuzzyLogic.PropertiesOperations
{
    public class DeMorganUnion : IBinaryProperty
    {
        public bool Operate(Set set1, Set set2)
        {
            var leftPart = Operation.Complementation(Operation.Intersection(set1, set2).Result);

            var rightPart = Operation.Union(Operation.Complementation(set1).Result, Operation.Complementation(set2).Result);

            return leftPart.Result.Equals(rightPart.Result);
        }
    }
}
