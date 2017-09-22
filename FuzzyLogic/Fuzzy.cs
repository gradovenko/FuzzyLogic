using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FuzzyLogic.Operations;

namespace FuzzyLogic
{
    public class Fuzzy
    {
        private ICollection<double> Sets1 { get; set; }
        private ICollection<double> Sets2 { get; set; }
        public Fuzzy(ICollection<double> sets1, ICollection<double> sets2)
        {
            Sets1 = sets1;
            Sets2 = Sets2;
        }
    }
}
