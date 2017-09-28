using FuzzyLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using FuzzyLogic.Operations;
using FuzzyLogic.PropertiesOperations;
using FuzzyLogic.Sets;

namespace TestConsoleApp
{
    internal struct NSet
    {
        public string Name { get; set; }
        public Set Set { get; set; }

        public NSet(string name, Set set)
        {
            Name = name;
            Set = set;
        }
    }
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

            var collection = new List<NSet> {new NSet("C0", A), new NSet("C1", B), new NSet("C3", C)};

            Run(collection);
            

            //var leftBracket = Operation.AlgebraicIntersection(A, B).Result;
            //var leftPart = Operation.AlgebraicUnion(A, leftBracket).Result;

            ////Console.WriteLine(leftPart);

            //var rightLeftBracket = Operation.AlgebraicUnion(A, B).Result;
            //var rightRightBracket = Operation.AlgebraicUnion(A, C).Result;
            //var rightPart = Operation.AlgebraicIntersection(rightLeftBracket, rightRightBracket).Result;

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

            //Console.WriteLine(Operation.AlgebraicUnion(A, Operation.Intersection(B, C).Result).Result);

            //Console.WriteLine(Operation.Intersection(Operation.AlgebraicUnion(A, B).Result, Operation.AlgebraicUnion(A, C).Result).Result);


            Console.ReadKey();
        }

        public static async void Run(IEnumerable<NSet> sets)
        {
            var masterSets = sets.ToList();
            foreach (var set in masterSets)
            {
                Console.WriteLine($"{set.Name} дополнение: {!set.Set}");
                Console.WriteLine($"{set.Name} концентрация: {await Operation.Power(set.Set, 2)}");
                Console.WriteLine($"{set.Name} растяжение: {await Operation.Power(set.Set, 0.5)}");
                Console.WriteLine($"{set.Name} объедение {set.Name}: {set.Set | set.Set}");
            }
            var i = 0;
            while (true)
            {
                Console.WriteLine($"{masterSets[i].Name} объедение {masterSets[i].Name}: {masterSets[i].Set | masterSets[i + 1].Set}");
                Console.WriteLine($"{masterSets[i].Name} пересечение {masterSets[i].Name}: {masterSets[i].Set & masterSets[i + 1].Set}");
            }
            //Console.WriteLine($"{masterSets[0].Name} объедение {masterSets[1].Name}: {masterSets[0].Set | masterSets[1].Set}");
            //Console.WriteLine($"{masterSets[1].Name} объедение {masterSets[2].Name}: {masterSets[1].Set | masterSets[2].Set}");
            //Console.WriteLine($"{masterSets[2].Name} объедение {masterSets[0].Name}: {masterSets[2].Set | masterSets[0].Set}");
            //Console.WriteLine($"{masterSets[0].Name} пересечение {masterSets[1].Name}: {masterSets[0].Set & masterSets[1].Set}");
            //Console.WriteLine($"{masterSets[1].Name} пересечение {masterSets[2].Name}: {masterSets[1].Set & masterSets[2].Set}");
            //Console.WriteLine($"{masterSets[2].Name} пересечение {masterSets[0].Name}: {masterSets[2].Set & masterSets[0].Set}");
            //Console.WriteLine($"{masterSets[0].Name} алг объедение {masterSets[1].Name}: {masterSets[0].Set + masterSets[1].Set}");
            //Console.WriteLine($"{masterSets[1].Name} алг объедение {masterSets[2].Name}: {masterSets[1].Set + masterSets[2].Set}");
            //Console.WriteLine($"{masterSets[2].Name} алг объедение {masterSets[0].Name}: {masterSets[2].Set + masterSets[0].Set}");
            //Console.WriteLine($"{masterSets[0].Name} алг пересечение {masterSets[1].Name}: {masterSets[0].Set * masterSets[1].Set}");
            //Console.WriteLine($"{masterSets[1].Name} алг пересечение {masterSets[2].Name}: {masterSets[1].Set * masterSets[2].Set}");
            //Console.WriteLine($"{masterSets[2].Name} алг пересечение {masterSets[0].Name}: {masterSets[2].Set * masterSets[0].Set}");

        }
    }
}
