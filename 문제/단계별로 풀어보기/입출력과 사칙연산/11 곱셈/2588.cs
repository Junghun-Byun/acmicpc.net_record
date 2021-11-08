using System;

namespace Test
{
    class Program
    {
        static void Main()
        {
            int var1 = int.Parse(Console.ReadLine());
            int var2 = int.Parse(Console.ReadLine());
            int var5 = var1 * var2;

            do
            {
                Console.WriteLine($"{var1 * (var2 % 10)}");
                var2 /= 10;
            }
            while (var2 != 0);

            Console.WriteLine($"{var5}");
        }
    }
}
