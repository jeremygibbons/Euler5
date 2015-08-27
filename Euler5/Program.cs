using System;

namespace Euler5
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n;
            uint.TryParse(args[0], out n);

            ulong p = 2;

            for (uint i = 3; i <= n; i++)
            {
                p = p * i / GCD(p, i);
            }

            Console.WriteLine(p);
            Console.ReadLine();
        }

        static ulong GCD(ulong a, ulong b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }
    }
}
