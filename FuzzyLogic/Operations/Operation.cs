using System.Linq;
using System.Threading.Tasks;
using FuzzyLogic.Sets;

namespace FuzzyLogic.Operations
{
    public class Operation
    {
        #region UnaryOperations

        public static async Task<Set> Complementation(Set set) => await Task.Run(
            () => new Set(set.CurrentSet.Select(element => new Complementation().Operate(element))));

        public static async Task<Set> Power(Set set, double degree) => await Task.Run(
            () => new Set(set.CurrentSet.Select(element => new Power().Operate(element, degree))));

        public static async Task<Set> ProductByNumber(Set set, double number) => await Task.Run(
            () => new Set(set.CurrentSet.Select(element => new ProductByNumber().Operate(element, number))));

        #endregion

        #region BinaryOperations

        #region Intersection

        public static async Task<Set> Intersection(Set set1, Set set2) => await Task.Run(
            () => new Set(set1.CurrentSet.Zip(set2.CurrentSet, (a, b) => new Intersection().Operate(a, b))));

        public static async Task<Set> AlgebraicIntersection(Set set1, Set set2) => await Task.Run(
            () => new Set(set1.CurrentSet.Zip(set2.CurrentSet, (a, b) => new AlgebraicIntersection().Operate(a, b))));

        public static async Task<Set> BoundedIntersection(Set set1, Set set2) => await Task.Run(
            () => new Set(set1.CurrentSet.Zip(set2.CurrentSet, (a, b) => new BoundedIntersection().Operate(a, b))));

        public static async Task<Set> DrasticIntersection(Set set1, Set set2) => await Task.Run(
            () => new Set(set1.CurrentSet.Zip(set2.CurrentSet, (a, b) => new DrasticIntersection().Operate(a, b))));

        #endregion

        #region Union

        public static async Task<Set> Union(Set set1, Set set2) => await Task.Run(
            () => new Set(set1.CurrentSet.Zip(set2.CurrentSet, (a, b) => new Union().Operate(a, b))));

        public static async Task<Set> AlgebraicUnion(Set set1, Set set2) => await Task.Run(
            () => new Set(set1.CurrentSet.Zip(set2.CurrentSet, (a, b) => new Union().Operate(a, b))));

        public static async Task<Set> BoundedUnion(Set set1, Set set2) => await Task.Run(
            () => new Set(set1.CurrentSet.Zip(set2.CurrentSet, (a, b) => new Union().Operate(a, b))));

        public static async Task<Set> DrasticUnion(Set set1, Set set2) => await Task.Run(
            () => new Set(set1.CurrentSet.Zip(set2.CurrentSet, (a, b) => new Union().Operate(a, b))));

        #endregion

        #region Sum

        /// <summary>
        /// 
        /// </summary>
        /// <param name="set1"></param>
        /// <param name="set2"></param>
        /// <returns></returns>
        public async Task<Set> DisjunctionSum(Set set1, Set set2) => await Task.Run(
            () => new Set(set1.CurrentSet.Zip(set2.CurrentSet, (a, b) => new DisjunctionSum().Operate(a, b))));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="set1"></param>
        /// <param name="set2"></param>
        /// <param name="lambda"></param>
        /// <returns></returns>
        public async Task<Set> LambdaSum(Set set1, Set set2, double lambda) => await Task.Run(
            () => new Set(set1.CurrentSet.Zip(set2.CurrentSet, (a, b) => new LambdaSum().Operate(lambda, a, b))));

        #endregion

        #region Difference

        public async Task<Set> SetDifference(Set set1, Set set2) => await Task.Run(
            () => new Set(set1.CurrentSet.Zip(set2.CurrentSet, (a, b) => new SetDifference().Operate(a, b))));

        public async Task<Set> SymmetricDifference(Set set1, Set set2) => await Task.Run(
            () => new Set(set1.CurrentSet.Zip(set2.CurrentSet, (a, b) => new SymmetricDifference().Operate(a, b))));

        #endregion

        #endregion
    }
}
