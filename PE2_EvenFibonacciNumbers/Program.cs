using System;

namespace PE2_EvenFibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                long n = Convert.ToInt64(Console.ReadLine());
                long fb1 = 1;
                long fb2 = 1;
                long fbSwap;
                long sum = 0;
                while (n > fb2)
                {
                    fbSwap = fb2;
                    fb2 += fb1;
                    fb1 = fbSwap;
                    if (fb2 % 2 == 0 && n > fb2) sum += fb2;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
