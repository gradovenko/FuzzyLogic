using System.Linq;
using System.Threading.Tasks;
using FuzzyLogic.Sets;

namespace FuzzyLogic.Operations
{
    public class Operation
    {
        public static async Task<Set> Union(Set set1, Set set2) => await Task.Run(() => new Set(set1.CurrentSet.Zip(set2.CurrentSet, (a, b) => new Union().Operate(a, b))));

        public static async Task<Set> Intersection(Set set1, Set set2) => await Task.Run(() => new Set(set1.CurrentSet.Zip(set2.CurrentSet, (a, b) => new Intersection().Operate(a, b))));

        public static async Task<Set> Complementation(Set set) => await Task.Run(() => new Set(set.CurrentSet.ToList().Select(a => new Complementation().Operate(a))));

    }
}
