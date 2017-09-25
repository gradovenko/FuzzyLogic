using System.Linq;
using FuzzyLogic.Operations;
using FuzzyLogic.Sets;


namespace FuzzyLogic.PropertiesOperations
{
    public class CommutativityUnion : IBinaryProperty
    {
        //public bool Operate(Set set1, Set set2) => set1.CurrentSet.Zip(set2.CurrentSet, (a, b) => new Union().Operate(a, b)).SequenceEqual(set2.CurrentSet.Zip(set1.CurrentSet, (a, b) => new Union().Operate(a, b)));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="set1">A</param>
        /// <param name="set2">B</param>
        /// <returns></returns>
        public bool Operate(Set set1, Set set2) => new Operation().Union(set1, set2).Result.CurrentSet.SequenceEqual(new Operations.Operation().Union(set2, set1).Result.CurrentSet);
    }
}
