using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuzzyLogic.Operations;
using FuzzyLogic.Sets;

namespace FuzzyLogic.PropertiesOperations
{
    public class DistributivityIntersection : ITernaryProperty
    {
        public bool Operate(Set set1, Set set2, Set set3)
        {
            var leftBrackets = new Operation().Intersection(set2, set3).Result;
            var leftResult = new Operation().Union(set1, leftBrackets).Result;

            var rightLeftBrackets = new Operation().Union(set1, set2).Result;

            var rightRightBrackets = new Operation().Union(set1, set3).Result;

            var rightResult = new Operation().Intersection(rightLeftBrackets, rightRightBrackets).Result;

            return leftResult.CurrentSet.SequenceEqual(rightResult.CurrentSet);
        }
    }
}
