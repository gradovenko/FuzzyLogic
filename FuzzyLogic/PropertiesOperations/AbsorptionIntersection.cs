using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuzzyLogic.Operations;
using FuzzyLogic.Sets;

namespace FuzzyLogic.PropertiesOperations
{
    public class AbsorptionIntersection : IBinaryProperty
    {
        public bool Operate(Set set1, Set set2)
        {
            var rightBrackets = Operation.Intersection(set1, set2).Result;
            return Operation.Union(set1, rightBrackets).Result.CurrentSet.SequenceEqual(set1.CurrentSet);
        }
    }
}
