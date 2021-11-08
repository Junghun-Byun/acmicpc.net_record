using System;

namespace Test
{
    class Program
    {
        static void Main()
        {
            int[] input = Array.ConvertAll( Console.ReadLine().Split(), x => int.Parse(x) );
            int A = input[0], B = input[1];
            string result;

            if( A > B ) result = ">";
            else if( A < B ) result = "<";
            else result = "==";
            
            Console.WriteLine(result);
        }
    }
}
