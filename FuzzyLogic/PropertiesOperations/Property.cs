using System.Threading.Tasks;
using FuzzyLogic.Sets;

namespace FuzzyLogic.PropertiesOperations
{
    public class Property
    {
        public async Task<bool> CommutativityUnion(Set set1, Set set2) => await Task.Run(() => new CommutativityUnion().Operate(set1, set2));
    }
}
