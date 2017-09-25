﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuzzyLogic.Sets;

namespace FuzzyLogic.PropertiesOperations
{
    public interface ITernaryProperty
    {
        bool Operate(Set set1, Set set2, Set set3);
    }
}
