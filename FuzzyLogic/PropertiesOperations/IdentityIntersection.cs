using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuzzyLogic.Operations;
using FuzzyLogic.Sets;

namespace FuzzyLogic.PropertiesOperations
{
    public class IdentityIntersection : IBinaryProperty
    {
        public bool Operate(Set set, Set uSet) => Operation.Intersection(set, uSet).Result.Equals(set);
    }
}
