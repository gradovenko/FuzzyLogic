using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuzzyLogic.Operations;
using FuzzyLogic.Sets;

namespace FuzzyLogic.PropertiesOperations
{
    public class IdentityUnion : IBinaryProperty
    {
        public bool Operate(Set set, Set uSet) => Operation.Union(set, uSet).Result.Equals(uSet);
    }
}
