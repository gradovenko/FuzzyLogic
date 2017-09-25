using System.Linq;
using FuzzyLogic.Operations;
using FuzzyLogic.Sets;

namespace FuzzyLogic.PropertiesOperations
{
    public class CommutativityIntersection : IBinaryProperty
    {
        public bool Operate(Set set1, Set set2) => new Operation().Intersection(set1, set2).Result.CurrentSet.SequenceEqual(new Operations.Operation().Intersection(set2, set1).Result.CurrentSet);
    }
}
