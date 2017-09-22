using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyLogic.Operations
{
    public class Operations
    {
        public static IEnumerable<double> Union(IEnumerable<double> sets1, IEnumerable<double> sets2)
        {
            return sets1.Zip(sets2, (a, b) => new Union().Operate(a, b));
        }
    }
}
