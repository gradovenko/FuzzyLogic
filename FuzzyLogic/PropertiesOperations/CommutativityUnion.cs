using System.Linq;
using System.Runtime.InteropServices;
using FuzzyLogic.Operations;
using FuzzyLogic.Sets;


namespace FuzzyLogic.PropertiesOperations
{
    public class CommutativityUnion : IBinaryProperty
    {
        public bool Operate(Set set1, Set set2)
        {
            var leftPart = Operation.Union(set1, set2).Result;
            var rightPart = Operation.Union(set2, set1).Result;
            return leftPart.Equals(rightPart);
        }
    }
}
