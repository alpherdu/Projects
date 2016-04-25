using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV
{

    public class Solution
    {
        public bool WordPattern(string pattern, string str)
        {
            if (pattern == null && str == null) return true;

            if (pattern == null || str == null) return false;

            string[] strParts = str.Split(' ');
            if (pattern.Length != strParts.Length) return false;

            Dictionary<char, string> dictPS = new Dictionary<char, string>();
            Dictionary<string, char> dictSP = new Dictionary<string, char>();
            for (int i = 0; i < pattern.Length; i++)
            {
                if (!dictPS.ContainsKey(pattern[i]) && !dictSP.ContainsKey(strParts[i]))
                {
                    dictPS[pattern[i]] = strParts[i];
                    dictSP[strParts[i]] = pattern[i];
                }
                else if (!dictPS.ContainsKey(pattern[i]) || !dictSP.ContainsKey(strParts[i]))
                {
                    return false;
                }
                else if (dictPS[pattern[i]] != strParts[i] || dictSP[strParts[i]] != pattern[i])
                {
                    return false;
                }
            }

            return true;
        }
    }

}

