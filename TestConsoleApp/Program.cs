using FuzzyLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using FuzzyLogic.Operations;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new List<double>() {0.25, 0.3, 0.4};
            var b = new List<double>() { 0.54, 0.12, 0.93 };

            var l = Operations.Union(a, b).ToList();

            foreach (var x in l)
            {
                Console.WriteLine(x);
            }
        }
    }
}
