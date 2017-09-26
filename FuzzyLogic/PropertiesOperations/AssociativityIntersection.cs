using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuzzyLogic.Operations;
using FuzzyLogic.Sets;

namespace FuzzyLogic.PropertiesOperations
{
    public class AssociativityIntersection : ITernaryProperty
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="set1">A</param>
        /// <param name="set2">B</param>
        /// <param name="set3">C</param>
        /// <returns></returns>
        public bool Operate(Set set1, Set set2, Set set3)
        {
            var leftBrackets = Operation.Intersection(set1, set2).Result;
            var leftResult = Operation.Intersection(leftBrackets, set3).Result;

            var rightBrackets = Operation.Intersection(set2, set3).Result;
            var rightResult = Operation.Intersection(set1, rightBrackets).Result;

            return leftResult.Equals(rightResult);
        }
    }
}
