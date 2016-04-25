using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class Set11_EggDroppingPuzzleUnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IV.Set11_EggDroppingPuzzle edp = new IV.Set11_EggDroppingPuzzle();
            int x  = edp.MinTrails_Recursive(2, 10);

            Assert.AreEqual(4, x);
        }

        [TestMethod]
        public void TestMethod2()
        {
            IV.Set11_EggDroppingPuzzle edp = new IV.Set11_EggDroppingPuzzle();
            int x = edp.MinTrails_DP(2, 10);

            Assert.AreEqual(4, x);
        }

        [TestMethod]
        public void TestMethod3()
        {
            IV.Set11_EggDroppingPuzzle edp = new IV.Set11_EggDroppingPuzzle();
            int x = edp.MinTrails_DP(3, 10);

            Assert.AreEqual(4, x);
        }

        [TestMethod]
        public void TestMethod4()
        {
            IV.Set11_EggDroppingPuzzle edp = new IV.Set11_EggDroppingPuzzle();
            int x = edp.MinTrails_DP(2, 36);

            Assert.AreEqual(8, x);
        }

        [TestMethod]
        public void TestMethod5()
        {
            IV.Set11_EggDroppingPuzzle edp = new IV.Set11_EggDroppingPuzzle();
            int x = edp.MinTrails_DP(3, 36);

            Assert.AreEqual(8, x);
        }
    }
}
