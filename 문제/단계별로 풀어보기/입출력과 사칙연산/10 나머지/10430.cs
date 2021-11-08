using System;

namespace Test
{
    class Program
    {
        static void Main()
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), x => int.Parse(x));
            int A = input[0], B = input[1], C = input[2];

            Console.WriteLine($"{(A + B) % C}");
            Console.WriteLine($"{((A % C) + (B % C)) % C}");
            Console.WriteLine($"{(A * B) % C}");
            Console.WriteLine($"{((A % C) * (B % C)) % C}");
        }
    }
}
