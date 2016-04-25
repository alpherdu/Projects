using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LC
{
    public static class LC246_StrobogrammaticNumber
    {
        public static bool IsStrobogrammaticNumber(string num)
        {
            Dictionary<char, char> dict = new Dictionary<char, char>();
            dict['0'] = '0';
            dict['1'] = '1';
            dict['6'] = '9';
            dict['8'] = '8';
            dict['9'] = '6';

            if (num == null || num.Length == 0) return true;

            for (int i = 0; i <= (num.Length - 1) / 2; i++)
            {
                if (!dict.ContainsKey(num[i]) || !dict.ContainsKey(num[num.Length - 1 - i])) return false;

                if (dict[num[i]] != num[num.Length - 1 - i]) return false;
            }

            return true;
        }
    }
}
