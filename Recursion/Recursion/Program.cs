using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            List<string> steps = new List<string>();
            p.TowersOfHanoi(3, 'S', 'A', 'T', steps);



        }

        string BuildAbbr(string word)
        {
            return word.Length <= 2 ? word : word[0] + (word.Length - 2).ToString() + word[word.Length - 1];
        }
        static void RunTests()
        {
            Program p = new Program();

            var x = p.Factorial(5);

            var y = p.GCD(102, 68);

            List<string> steps = new List<string>();
            p.TowersOfHanoi(3, 'S', 'A', 'T', steps);


            var z = p.Fib(7);

            List<string> result = new List<string>();
            p.Permutation("", "1234", result);

            var a = p.GrayCode(4);

            steps = new List<string>();
            p.SamuelBeckett(2, true, steps);

            var b = p.IntToBinary(123);

            result = new List<string>();
            char[] A = { '1', '2', '3', '4' };
            p.perm2(A, A.Length, result);

            result = new List<string>();
            p.perm3(A, 0, result);
        }

        void Permutation(string prefix, string str, IList<string> result)
        {
            if (str.Length == 0) result.Add(prefix);
            else
            {
                for (int i = 0; i < str.Length; i++)
                    Permutation(prefix + str[i], str.Remove(i, 1), result);
            }
        }

        void perm3(char[] a, int startIndex, IList<string> result)
        {
            if (startIndex == a.Length)
            {
                result.Add(String.Join("", a));
                return;
            }

            for (int i = startIndex; i < a.Length; i++)
            {
                swap(a, startIndex, i);
                perm3(a, startIndex + 1, result);
                swap(a, startIndex, i);
            }
        }
        void perm2(char[] a, int n, IList<string> result)
        {
            if (n == 1)
            {
                result.Add(String.Join("", a));
                return;
            }
            for (int i = 0; i < n; i++)
            {
                swap(a, i, n - 1);
                perm2(a, n - 1, result);
                swap(a, i, n - 1);
            }
        }

        // swap the characters at indices i and j
        private static void swap(char[] a, int i, int j)
        {
            char c = a[i];
            a[i] = a[j];
            a[j] = c;
        }

        int Factorial(int n)
        {
            if (n == 1) return 1;

            return n * Factorial(n - 1);
        }

        int GCD(int p, int q)
        {
            if (p == 0 || q == 0) return p != 0 ? p : q;

            if (p > q) return GCD(q, p % q);
            else return GCD(p, q % p);
        }


        void TowersOfHanoi(int n, char source, char auxiliary, char target, IList<string> steps)
        {

            if (n == 0) return;

            TowersOfHanoi(n - 1, source, target, auxiliary, steps);
            steps.Add(n + " ---> " + target); //steps.Add(start + " ---> " + end);
            TowersOfHanoi(n - 1, auxiliary, source, target, steps);
        }

        int Fib(int n)
        {
            if (n <= 1) return n;
            return Fib(n - 1) + Fib(n - 2);
        }

        List<string> GrayCode(int n)
        {
            List<string> list = new List<string>();
            if (n == 0)
            {
                list.Add(string.Empty);
                return list;
            }

            List<string> preList = GrayCode(n - 1);

            for (int i = 0; i < preList.Count; i++)
            {
                list.Insert(i, '0' + preList[i]);
                list.Insert(i + 1, '1' + preList[i]);
            }

            return list;
        }

        void SamuelBeckett(int n, bool enter, List<string> steps)
        {
            if (n == 0) return;

            SamuelBeckett(n - 1, true, steps);

            steps.Add((enter ? "Enter" : "Exit") + ": " + n);

            SamuelBeckett(n - 1, false, steps);
        }

        string IntToBinary(int n)
        {
            if (n == 0) return string.Empty;

            return IntToBinary(n / 2) + (n % 2);

        }
    }
}
