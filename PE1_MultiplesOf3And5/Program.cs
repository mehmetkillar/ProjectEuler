using System;

namespace PE1_MultiplesOf3And5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                int t = Convert.ToInt32(Console.ReadLine());
                long num3;
                long num5;
                long num15;
                long sum = 0;

                for (int a0 = 0; a0 < t; a0++)
                {
                    int n = Convert.ToInt32(Console.ReadLine());
                    if (n>=1)
                    {
                        num3 = (n - 1) / 3;
                        num5 = (n - 1) / 5;
                        num15 = (n - 1) / 15;
                        sum = 3 * (num3 * (num3 + 1) / 2) + 5 * (num5 * (num5 + 1) / 2) - 15 * (num15 * (num15 + 1) / 2);
                        Console.WriteLine(sum);
                    }
                    

                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        
    }
}
