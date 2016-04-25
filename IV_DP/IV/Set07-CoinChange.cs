using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV
{
    public static class CoinChange
    {
        public static int CoinChange_Recursive(int[] coinSet, int value)
        {
            if (value == 0)
                return 1;

            if (value < 0)
                return 0;

            if (coinSet == null || coinSet.Length == 0)
                return 0;
            int waysWithLastCoin = CoinChange_Recursive(coinSet, value - coinSet[coinSet.Length - 1]);
            int wayswithoutLastCoin = CoinChange_Recursive(coinSet.SubArray(0, coinSet.Length - 1), value);

            return waysWithLastCoin + wayswithoutLastCoin;
        }

        public static int CoinChange_DP(int[] coinSet, int value)
        {
            if (value == 0)
                return 1;

            if (value < 0)
                return 0;

            if (coinSet == null || coinSet.Length == 0)
                return 0;

            int[,] waysCount = new int[value + 1, coinSet.Length];


            for (int coinIndex = 0; coinIndex < coinSet.Length; coinIndex++)
            {
                waysCount[0, coinIndex] = 1;
            }


            int waysWithLastCoin;
            int wayswithoutLastCoin;


            for (int valueIndex = 1; valueIndex < value + 1; valueIndex++)
            {
                for (int coinIndex = 0; coinIndex < coinSet.Length; coinIndex++)
                {

                    waysWithLastCoin = 0;
                    int remainingValueIndex = valueIndex - coinSet[coinIndex];
                    if (remainingValueIndex >= 0)
                    {
                        waysWithLastCoin = waysCount[remainingValueIndex, coinIndex];
                    }

                    wayswithoutLastCoin = 0;
                    if (coinIndex - 1 >= 0)
                    {
                        wayswithoutLastCoin = waysCount[valueIndex, coinIndex - 1];
                    }

                    waysCount[valueIndex, coinIndex] = waysWithLastCoin + wayswithoutLastCoin;
                }
            }

            return waysCount[value, coinSet.Length - 1];
        }

        public static int CoinChange_DP_Space_O_n(int[] coinSet, int value)
        {
            if (value == 0)
                return 1;

            if (value < 0)
                return 0;

            if (coinSet == null || coinSet.Length == 0)
                return 0;

            int[] waysCount = new int[value + 1];

            waysCount[0] = 1;
            for (int coinIndex = 0; coinIndex < coinSet.Length; coinIndex++)
            {
                for (int valueIndex = coinSet[coinIndex]; valueIndex < value + 1; valueIndex++)
                {
                    int remainingValueIndex = valueIndex - coinSet[coinIndex];
                    waysCount[valueIndex] += waysCount[remainingValueIndex];
                }
            }

            return waysCount[value];
        }
    }
}


