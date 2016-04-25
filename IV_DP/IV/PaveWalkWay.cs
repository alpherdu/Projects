using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV
{
    public static class PaveWalkWay
    {
        public static long PaveWalkWay_DP(int walkWayLen, int[] brickSet)
        {
            if (walkWayLen <= 0 || brickSet == null || brickSet.Length == 0)
                return 0;

            if(brickSet.Length != brickSet.Distinct().Count())
            {
                throw(new ArgumentException("Dup Brick Len in the Set"));
            }

            foreach (var brickLen in brickSet)
            {
                if (brickLen <= 0)
                    throw (new ArgumentException("Brick length is negative"));
            }

            long[] distance = new long[walkWayLen + 1];
            distance[0] = 1;

            for (int i = 1; i <= walkWayLen; i++)
            {
                foreach (var brickLen in brickSet)
                {
                    distance[i] += (i - brickLen) < 0 ? 0 : distance[i - brickLen];
                }
            }

            return distance[walkWayLen];
        }
    }
}
