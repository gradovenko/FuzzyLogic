﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuzzyLogic.Operations;
using FuzzyLogic.Sets;

namespace FuzzyLogic.PropertiesOperations
{
    public class IdempotencyUnion : IUnaryProperty
    {
        public bool Operate(Set set1) => new Operation().Union(set1, set1).Result.CurrentSet.SequenceEqual(set1.CurrentSet);
    }
}
