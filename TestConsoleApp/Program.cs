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
            var a = new List<double>() { 0, 0.4, 0.1, 0.7, 0.5, 0.8, 0 };
            var b = new List<double>() { 1, 0.7, 0.2, 0.5, 1, 0.4, 0.9 };
            var c = new List<double>() { 0.2, 0.6, 0.3, 0.2, 1, 0, 0.5 };

            var A = new FuzzyLogic.Sets.Set(a);
            var B = new FuzzyLogic.Sets.Set(b);
            var C = new FuzzyLogic.Sets.Set(c);


            var leftBracket = Operation.AlgebraicIntersection(A, B).Result;
            var leftPart = Operation.AlgebraicUnion(A, leftBracket).Result;

            //Console.WriteLine(leftPart);

            var rightLeftBracket = Operation.AlgebraicUnion(A, B).Result;
            var rightRightBracket = Operation.AlgebraicUnion(A, C).Result;
            var rightPart = Operation.AlgebraicIntersection(rightLeftBracket, rightRightBracket).Result;

            //Console.WriteLine(rightPart);

            //var r = new Operations().Union(set1, set2).Result.CurrentSet;

            //foreach (var aaa in r)
            //{
            //    Console.WriteLine(aaa);
            //}

            //Console.WriteLine(Operation.);

            //Console.WriteLine(Operation.Union(setB, setA).Result);

            //Console.WriteLine(Operation.AlgebraicIntersection(B, C).Result);

            //Console.WriteLine(Operation.AlgebraicUnion(A, Operation.AlgebraicIntersection(B, C).Result).Result);


            //Console.WriteLine(Operation.AlgebraicUnion(A, B).Result);

            //Console.WriteLine(Operation.AlgebraicUnion(A, C).Result);

            //Console.WriteLine(Operation.AlgebraicIntersection(Operation.AlgebraicUnion(A, B).Result, Operation.AlgebraicUnion(A, C).Result).Result);

            //Console.WriteLine(Operation.AlgebraicIntersection(A, Operation.AlgebraicUnion(B, C).Result).Result);
           
            //Console.WriteLine(Operation.AlgebraicUnion(Operation.AlgebraicIntersection(A, B).Result, Operation.AlgebraicIntersection(A, C).Result).Result);

            Console.WriteLine(Operation.AlgebraicUnion(A, Operation.Intersection(B, C).Result).Result);

            Console.WriteLine(Operation.Intersection(Operation.AlgebraicUnion(A, B).Result, Operation.AlgebraicUnion(A, C).Result).Result);


            Console.ReadKey();
        }

        //public async void Run()
        //{
        //    Console.WriteLine(await Property.CommutativityIntersection(setA, setB));
        //}
    }
}
