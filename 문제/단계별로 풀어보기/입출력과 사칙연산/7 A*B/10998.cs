using System;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), x => int.Parse(x));

            Console.WriteLine(input.Aggregate((A, B) => A * B));
        }
    }
}
