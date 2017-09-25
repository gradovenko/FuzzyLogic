using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuzzyLogic.Sets;

namespace FuzzyLogic.PropertiesOperations
{
    public interface IUnaryProperty
    {
        bool Operate(Set set);
    }
}
