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
            var a = new Operations();
            Console.WriteLine(Operations.Union(5,3));
        }
    }
}
