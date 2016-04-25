using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IV_SegmentTree;
using System.Linq;

namespace SegmentTreeUnitTest
{
    [TestClass]
    public class STDelegateMaxUnitTest
    {

        [TestMethod]
        public void SumAllTestMethod()
        {
            int[] array = { 3, 6, 5, 8, 7, 1, 6 };
            STDelegate st = new STDelegate(array, (x, y) => Math.Max(x, y));
            var res = st.Query(0, array.Length - 1, int.MinValue);

            Assert.AreEqual(array.Max(), res);
        }

        [TestMethod]
        public void ParialsumTestMethod()
        {
            int[] array = { 3, 6, 5, 8, 7, 1, 6 };
            STDelegate st = new STDelegate(array, (x, y) => Math.Max(x, y));
            var res = st.Query(1, 5, int.MinValue);

            Assert.AreEqual(8, res);
        }

        [TestMethod]
        public void ModifySumAllTestMethod()
        {
            int[] array = { 3, 6, 5, 8, 7, 1, 6 };
            STDelegate st = new STDelegate(array, (x, y) => Math.Max(x, y));
            st.Modify(2, 10);
            var res = st.Query(0, array.Length - 1, int.MinValue);

            Assert.AreEqual(10, res);
        }

        [TestMethod]
        public void ModifyParialsumTestMethod()
        {
            int[] array = { 3, 6, 5, 8, 7, 1, 6 };
            STDelegate st = new STDelegate(array, (x, y) => Math.Max(x, y));
            st.Modify(3, -9);
            var res = st.Query(1, 5, int.MinValue);

            Assert.AreEqual(7, res);
        }
    }
}
