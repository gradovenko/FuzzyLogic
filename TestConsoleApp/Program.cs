using FuzzyLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using FuzzyLogic.Operations;
using FuzzyLogic.PropertiesOperations;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new List<double>() { 0.8, 1, 0.6 };
            var b = new List<double>() { 0.7, 1, 0.5};

            var set1 = new FuzzyLogic.Sets.Set(a);
            var set2 = new FuzzyLogic.Sets.Set(b);
            var result1 = set1.Union(set2).Result;
            var result2 = set2.Union(set1).Result;

            foreach (var x in result1)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine();

            foreach (var x in result2)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine();

            //var r = new Operations().Union(set1, set2).Result.CurrentSet;

            //foreach (var aaa in r)
            //{
            //    Console.WriteLine(aaa);
            //}

            FuzzyLogic.Operations.

            Console.WriteLine(result);
        }
    }
}
