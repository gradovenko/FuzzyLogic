using System.Linq;
using System.Threading.Tasks;
using FuzzyLogic.Sets;

namespace FuzzyLogic.Operations
{
    public class Operation
    {
        public async Task<Set> Union(Set set1, Set set2) => await Task.Run(() => new Set(set1.CurrentSet.Zip(set2.CurrentSet, (a, b) => new Union().Operate(a, b))));

        public async Task<Set> Intersection(Set set1, Set set2) => await Task.Run(() => new Set(set1.CurrentSet.Zip(set2.CurrentSet, (a, b) => new Intersection().Operate(a, b))));

    }
}
