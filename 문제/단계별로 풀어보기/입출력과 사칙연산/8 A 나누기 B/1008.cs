using System;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Array.ConvertAll(Console.ReadLine().Split(), x => double.Parse(x));

            Console.WriteLine(input.Aggregate((A, B) => A / B));
        }
    }
}
