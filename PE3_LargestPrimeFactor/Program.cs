using System;

namespace PE3_LargestPrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                long n = Convert.ToInt64(Console.ReadLine());
                //if(n%2==0)
                //for(int i = 0; i < n/2; i+=2)
                //{

                //}
                //for (long i = 2; n%i==0 && n>i; i++)
                //{
                //    n /= i;
                //    Console.WriteLine(i);
                //}


                //for (i = 3; i < n; i+=2)
                //{

                //}
                while (n%2==0)n /= 2;
                if (n < 2) Console.WriteLine(2);
                else
                {
                    int i = 3;
                    while (n > i)
                    {
                        if (n % i == 0) n /= i;
                        else if (n > i) i += 2;
                    }
                    Console.WriteLine(i);   
                }
                //while (i < n)
                //{
                //    while (n % i == 0)
                //    {
                //        n /= i;
                //    }
                //    if(n>i) i += 2;
                //}
                //Console.WriteLine(i);


                //switch (n)
                //{
                //    case 2:
                //        i = 2;
                //        Console.WriteLine(i);
                //        break;
                //    default:
                //        while (n > 1)
                //        {
                //            if (n % i == 0)
                //            {
                //                n /= i;
                //                Console.WriteLine(i);
                //            }
                //            else i += 2;
                //        }
                //        break;
                //}


            }

        }

        //static int mm(long n)
        //{
        //    while (n > 1)
        //    {
        //        if (n % i == 0)
        //        {
        //            n /= i;
        //            Console.WriteLine(i);
        //        }
        //        else i += 2;
        //    }
        //}
    }
}
