using System.Threading.Tasks;
using FuzzyLogic.Sets;

namespace FuzzyLogic.PropertiesOperations
{
    public class Property
    {
        //TODO: Переделать свойства операций для общего ввида

        #region Commutativity

        public static async Task<bool> CommutativityUnion(Set set1, Set set2) => await Task.Run(
            () => new CommutativityUnion().Operate(set1, set2));

        public static async Task<bool> CommutativityIntersection(Set set1, Set set2) => await Task.Run(
            () => new CommutativityIntersection().Operate(set1, set2));

        #endregion

        #region Associativity

        public static async Task<bool> AssociativityUnion(Set set1, Set set2, Set set3) => await Task.Run(
            () => new AssociativityUnion().Operate(set1, set2, set3));

        public static async Task<bool> AssociativityIntersection(Set set1, Set set2, Set set3) => await Task.Run(
            () => new AssociativityIntersection().Operate(set1, set2, set3));

        #endregion

        #region Distributivity

        public static async Task<bool> DistributivityUnion(Set set1, Set set2, Set set3) => await Task.Run(
            () => new DistributivityUnion().Operate(set1, set2, set3));

        public static async Task<bool> DistributivityIntersection(Set set1, Set set2, Set set3) => await Task.Run(
            () => new DistributivityIntersection().Operate(set1, set2, set3));

        #endregion

        #region Idempotency

        public static async Task<bool> IdempotencyUnion(Set set) => await Task.Run(
            () => new IdempotencyUnion().Operate(set));

        public static async Task<bool> IdempotencyIntersection(Set set) => await Task.Run(
            () => new IdempotencyIntersection().Operate(set));

        #endregion

        #region Absorption

        public static async Task<bool> AbsorptionUnion(Set set1, Set set2) => await Task.Run(
            () => new AbsorptionUnion().Operate(set1, set2));

        public static async Task<bool> AbsorptionIntersection(Set set1, Set set2) => await Task.Run(
            () => new AbsorptionIntersection().Operate(set1, set2));

        #endregion

        #region Identity

        public static async Task<bool> IdentityUnion(Set set, Set uSet) => await Task.Run(
            () => new IdentityUnion().Operate(set, uSet));

        public static async Task<bool> IdentityIntersection(Set set1, Set set2) => await Task.Run(
            () => new IdentityIntersection().Operate(set1, set2));

        #endregion

        #region Domination

        public static async Task<bool> DominationUnion(Set set) => await Task.Run(
            () => new DominationUnion().Operate(set));

        public static async Task<bool> DominationIntersection(Set set) => await Task.Run(
            () => new DominationIntersection().Operate(set));

        #endregion

        #region DoubleComplementation_Or_Involution

        public static async Task<bool> DoubleComplementation(Set set) => await Task.Run(
            () => new DoubleComplementation().Operate(set));

        #endregion

        #region DeMorgan

        public static async Task<bool> DeMorganUnion(Set set1, Set set2) => await Task.Run(
            () => new DeMorganUnion().Operate(set1, set2));

        public static async Task<bool> DeMorganIntersection(Set set1, Set set2) => await Task.Run(
            () => new DeMorganIntersection().Operate(set1, set2));

        #endregion
    }
}
