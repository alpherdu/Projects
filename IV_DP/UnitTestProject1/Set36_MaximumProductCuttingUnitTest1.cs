using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class Set36_MaximumProductCuttingUnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IV.Set36_MaximumProductCutting mpc = new IV.Set36_MaximumProductCutting();
            for (int L = 0; L <= 12; L++)
            {
                var product = mpc.MaxProductCut_Recursive(L);
                System.Diagnostics.Debug.WriteLine("L={0}, product={1}", L, product);
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            IV.Set36_MaximumProductCutting mpc = new IV.Set36_MaximumProductCutting();
            for (int L = 0; L <= 12; L++)
            {
                var product = mpc.MaxProductCut_Dp(L);
                System.Diagnostics.Debug.WriteLine("L={0}, product={1}", L, product);
            }
        }

    }
}
