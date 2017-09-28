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

        #region UnaryOperations

        public async Task<Set> Complement() => await Task.Run(() => Operation.Complementation(this));

        public async Task<Set> Power(double degree) => await Task.Run(() => Operation.Power(this, degree));

        public async Task<Set> ProductByNumber(double number) =>
            await Task.Run(() => Operation.ProductByNumber(this, number));

        #endregion

        #region BinaryOperations

        #region Intersection

        public async Task<Set> Intersection(Set set) => await Task.Run(() => Operation.Intersection(this, set));

        public async Task<Set> AlgebraicIntersection(Set set) => await Task.Run(() => Operation.AlgebraicUnion(this, set));

        public async Task<Set> BoundedIntersection(Set set) => await Task.Run(() => Operation.BoundedIntersection(this, set));

        public async Task<Set> DrasticIntersection(Set set) => await Task.Run(() => Operation.DrasticIntersection(this, set));

        #endregion
        
        #region Union

        public async Task<Set> Union(Set set) => await Task.Run(() => Operation.Union(this, set));

        public async Task<Set> AlgebraicUnion(Set set) => await Task.Run(() => Operation.AlgebraicUnion(this, set));

        public async Task<Set> BoundedUnion(Set set) => await Task.Run(() => Operation.BoundedUnion(this, set));

        public async Task<Set> DrasticUnion(Set set) => await Task.Run(() => Operation.DrasticUnion(this, set));

        #endregion

        #region Sum

        public async Task<Set> DisjunctionSum(Set set) => await Task.Run(() => Operation.DisjunctionSum(this, set));

        public async Task<Set> LambdaSum(Set set, double lambda) => await Task.Run(() => Operation.LambdaSum(this, set, lambda));

        #endregion

        #region Difference

        public async Task<Set> SetDifference(Set set) => await Task.Run(() => new Set(CurrentSet.Zip(set.CurrentSet, (a, b) => new SetDifference().Operate(a, b))));

        public async Task<Set> SymmetricDifference(Set set) => await Task.Run(() => new Set(CurrentSet.Zip(set.CurrentSet, (a, b) => new SymmetricDifference().Operate(a, b))));

        #endregion

        #endregion

        #region OverrideMethods

        public static bool operator == (Set set1, Set set2)
        {
            if (ReferenceEquals(set1, set2))
                return true;

            if (set1 == null || set2 == null)
                return false;

            return set1.Equals(set2);
        }

        public static bool operator != (Set set1, Set set2) => !set1.Equals(set2);

        public static Set operator !(Set set) => Operation.Complementation(set).Result;

        public static Set operator &(Set set1, Set set2) => Operation.Intersection(set1, set2).Result;

        public static Set operator |(Set set1, Set set2) => Operation.Union(set1, set2).Result;

        public static Set operator *(Set set1, Set set2) => Operation.AlgebraicIntersection(set1, set2).Result;

        public static Set operator +(Set set1, Set set2) => Operation.AlgebraicUnion(set1, set2).Result;

        public static Set operator -(Set set1, Set set2) => Operation.Difference(set1, set2).Result;

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            var set = (Set)obj;
            return CurrentSet.SequenceEqual(set.CurrentSet);
        }

        protected bool Equals(Set set) => Equals(CurrentSet, set.CurrentSet);

        public override int GetHashCode() => CurrentSet != null ? CurrentSet.GetHashCode() : 0;

        public override string ToString() => CurrentSet.Aggregate(string.Empty, (current, element) => current + $"{element} ");
        
        #endregion
    }
}
