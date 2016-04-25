using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV
{
    static public class FibonacciNumbers
    {
        // recursive
        static public int FibonacciNumber_Recursive(int n)
        {
            if(n <= 1)
            {
                return n;
            }
            else
            {
                return FibonacciNumber_Recursive(n - 1) + FibonacciNumber_Recursive(n - 2);
            }
        }

        //Tabulation --- Bottom UP
        static public int FibonacciNumbers_DP_Tabulation_BottomUp(int n)
        {
            int[] fib = new int[n+1];

            fib[0] = 0;
            fib[1] = 1;

            for (int i = 2; i < n+1; i++)
            {
                fib[i] = fib[i - 2] + fib[i - 1];
            }

            return fib[n];
        }

        //Memorization --- Top Down
        public static int MAX_NUM = 30;
        static int[] fibLookup = Enumerable.Repeat<int>(int.MinValue, MAX_NUM + 1).ToArray<int>();

        static public int FibonacciNumbers_DP_Memorization_TopDown(int n)
        {
            if(fibLookup[n] == int.MinValue)
            {
                if (n <= 1)
                {
                    fibLookup[n] = n;
                }
                else
                {
                    fibLookup[n] = FibonacciNumbers_DP_Memorization_TopDown(n - 1) + FibonacciNumbers_DP_Memorization_TopDown(n - 2);
                }
            }

            return fibLookup[n];
        }
    }
}
