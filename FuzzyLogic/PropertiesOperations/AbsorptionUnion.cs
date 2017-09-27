using System.Linq;
using FuzzyLogic.Operations;
using FuzzyLogic.Sets;

namespace FuzzyLogic.PropertiesOperations
{
    public class AbsorptionUnion : IBinaryProperty
    {
        public bool Operate(Set set1, Set set2)
        {
            var rightBrackets = Operation.Union(set1, set2).Result;
            return Operation.Intersection(set1, rightBrackets).Result.CurrentSet.SequenceEqual(set1.CurrentSet);
        }
    }
}
