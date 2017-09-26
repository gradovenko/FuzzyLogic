using System.Linq;
using FuzzyLogic.Operations;
using FuzzyLogic.Sets;

namespace FuzzyLogic.PropertiesOperations
{
    public class AssociativityUnion : ITernaryProperty
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
            var leftBrackets = Operation.Union(set1, set2).Result;
            var leftResult = Operation.Union(leftBrackets, set3).Result;

            var rightBrackets = Operation.Union(set2, set3).Result;
            var rightResult = Operation.Union(set1, rightBrackets).Result;

            return leftResult.Equals(rightResult);
        }
}
}
