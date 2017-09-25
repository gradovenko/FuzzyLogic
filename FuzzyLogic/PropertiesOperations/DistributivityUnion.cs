using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuzzyLogic.Operations;
using FuzzyLogic.Sets;

namespace FuzzyLogic.PropertiesOperations
{
    public class DistributivityUnion : ITernaryProperty
    {
        public bool Operate(Set set1, Set set2, Set set3)
        {
            var leftBrackets = new Operation().Union(set2, set3).Result;
            var leftResult = new Operation().Intersection(set1, leftBrackets).Result;

            var rightLeftBrackets = new Operation().Intersection(set1, set2).Result;
            var rightRightBrackets = new Operation().Intersection(set1, set3).Result;        
            var rightResult = new Operation().Union(rightLeftBrackets, rightRightBrackets).Result;

            return leftResult.CurrentSet.SequenceEqual(rightResult.CurrentSet);
        }
    }
}
