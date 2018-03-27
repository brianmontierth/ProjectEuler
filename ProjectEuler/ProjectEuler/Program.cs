using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Problem_14();

            Console.ReadLine();
        }

        public static void Problem_14()
        {
            //Which starting number, under one million, produces the longest chain?

            long longestCount = 0;
            long longestStart = 0;

            for (long i = 1; i < 1000000; i++)
            {
                long count = 1;
                for (long j = i; j > 1; j = (j % 2 == 0) ? j/2 : j*3+1)
                {
                    count++;
                }

                if (count > longestCount)
                {
                    longestCount = count;
                    longestStart = i;
                }
            }

            Console.WriteLine(longestStart);
        }


        public static void Problem_88()
        {
            long productSum = 0;

            for (int k = 2; k <= 12000; k++)
            {
                //find factorizations of all integers between k + 2 - K * 2


            }
        }
    }
}
