using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IV;

namespace UnitTestProject1
{
    [TestClass]
    public class Set20_MaximumLengthChainOfPairsUnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Pair p = new Pair { x = 1, y = 2 };

            Pair[] pairs = {
                new Pair { x=5, y=24},
                new Pair { x=15, y=25},
                new Pair { x=27, y=40},
                new Pair { x=50, y=60} };

            IV.Set20_MaximumLengthChainOfPairs mlcp = new Set20_MaximumLengthChainOfPairs();
            var x = mlcp.MaxLengthPairs(pairs);
        }
    }
}
