using System.Threading.Tasks;
using FuzzyLogic.Sets;

namespace FuzzyLogic.PropertiesOperations
{
    public class Property
    {
        public static async Task<bool> CommutativityUnion(Set set1, Set set2) => await Task.Run(
            () => new CommutativityUnion().Operate(set1, set2));

        public static async Task<bool> CommutativityIntersection(Set set1, Set set2) => await Task.Run(
            () => new CommutativityIntersection().Operate(set1, set2));

        public static async Task<bool> AssociativityUnion(Set set1, Set set2, Set set3) => await Task.Run(
            () => new AssociativityUnion().Operate(set1, set2, set3));

        public static async Task<bool> AssociativityIntersection(Set set1, Set set2, Set set3) => await Task.Run(
            () => new AssociativityIntersection().Operate(set1, set2, set3));

        public static async Task<bool> AbsorptionUnion(Set set1, Set set2) => await Task.Run(
            () => new AbsorptionUnion().Operate(set1, set2));

        public static async Task<bool> AbsorptionIntersection(Set set1, Set set2) => await Task.Run(
            () => new AbsorptionIntersection().Operate(set1, set2));
    }
}
