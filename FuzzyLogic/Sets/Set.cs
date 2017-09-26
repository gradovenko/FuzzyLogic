using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using FuzzyLogic.Operations;
using FuzzyLogic.PropertiesOperations;

namespace FuzzyLogic.Sets
{
    public class Set
    {
        #region Properties

        public IEnumerable<double> CurrentSet { get; }

        #endregion

        #region Constructor

        public Set(IEnumerable<double> currentSet)
        {
            CurrentSet = currentSet;
        }

        #endregion

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            var set = (Set)obj;
            return CurrentSet.SequenceEqual(set.CurrentSet);
        } 

        #region UnaryOperations

        public async Task<IEnumerable<double>> Complement() => await Task.Run(() => CurrentSet.Select(obj => new Complementation().Operate(obj)));

        public async Task<IEnumerable<double>> Power(double degree) => await Task.Run(() => CurrentSet.Select(obj => new Power().Operate(obj, degree)));

        public async Task<IEnumerable<double>> ProductByNumber(double number) => await Task.Run(() => CurrentSet.Select(obj => new ProductByNumber().Operate(number, obj)));

        #endregion

        #region BinaryOperations

        #region Intersection

        public async Task<IEnumerable<double>> Intersection(Set set) => await Task.Run(() => CurrentSet.Zip(set.CurrentSet, (a, b) => new Intersection().Operate(a, b)));

        public async Task<IEnumerable<double>> AlgebraicIntersection(Set set) => await Task.Run(() => CurrentSet.Zip(set.CurrentSet, (a, b) => new AlgebraicIntersection().Operate(a, b)));

        public async Task<IEnumerable<double>> BoundedIntersection(Set set) => await Task.Run(() => CurrentSet.Zip(set.CurrentSet, (a, b) => new BoundedIntersection().Operate(a, b)));

        public async Task<IEnumerable<double>> DrasticIntersection(Set set) => await Task.Run(() => CurrentSet.Zip(set.CurrentSet, (a, b) => new DrasticIntersection().Operate(a, b)));

        #endregion
        
        #region Union

        public async Task<IEnumerable<double>> Union(Set set) => await Task.Run(() => CurrentSet.Zip(set.CurrentSet, (a, b) => new Union().Operate(a, b)));

        public async Task<IEnumerable<double>> AlgebraicUnion(Set set) => await Task.Run(() => CurrentSet.Zip(set.CurrentSet, (a, b) => new Union().Operate(a, b)));

        public async Task<IEnumerable<double>> BoundedUnion(Set set) => await Task.Run(() => CurrentSet.Zip(set.CurrentSet, (a, b) => new Union().Operate(a, b)));

        public async Task<IEnumerable<double>> DrasticUnion(Set set) => await Task.Run(() => CurrentSet.Zip(set.CurrentSet, (a, b) => new Union().Operate(a, b)));

        #endregion

        #region Sum

        public async Task<IEnumerable<double>> DisjunctionSum(Set set) => await Task.Run(() => CurrentSet.Zip(set.CurrentSet, (a, b) => new DisjunctionSum().Operate(a, b)));

        /// <summary>
        /// Лямбда - сумма
        /// </summary>
        /// <param name="lambda">Лямбда</param>
        /// <param name="set">Нечеткое множество</param>
        /// <returns>Нечеткое множество</returns>
        public async Task<IEnumerable<double>> LambdaSum(double lambda, Set set) => await Task.Run(() => CurrentSet.Zip(set.CurrentSet, (a, b) => new LambdaSum().Operate(lambda, a, b)));

        #endregion

        #region Difference

        public async Task<IEnumerable<double>> SetDifference(Set set) => await Task.Run(() => CurrentSet.Zip(set.CurrentSet, (a, b) => new SetDifference().Operate(a, b)));

        public async Task<IEnumerable<double>> SymmetricDifference(Set set) => await Task.Run(() => CurrentSet.Zip(set.CurrentSet, (a, b) => new SymmetricDifference().Operate(a, b)));

        #endregion

        #endregion



        //public async Task<bool> CommutativityUnion(Set set) => await Task.Run(() => new CommutativityUnion().Operate(CurrentSet, set.CurrentSet));

    }
}
