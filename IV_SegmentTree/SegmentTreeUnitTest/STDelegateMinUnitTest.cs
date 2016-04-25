using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IV_SegmentTree;
using System.Linq;

namespace SegmentTreeUnitTest
{
    [TestClass]
    public class STDelegateMinUnitTest
    {

        [TestMethod]
        public void SumAllTestMethod()
        {
            int[] array = { 3, 6, 5, 8, 7, 1, 6 };
            STDelegate st = new STDelegate(array, (x, y) => Math.Min(x, y));
            var res = st.Query(0, array.Length - 1, int.MaxValue);

            Assert.AreEqual(array.Min(), res);
        }

        [TestMethod]
        public void ParialsumTestMethod()
        {
            int[] array = { 3, 6, 5, 8, 7, 1, 6 };
            STDelegate st = new STDelegate(array, (x, y) => Math.Min(x, y));
            var res = st.Query(1, 5, int.MaxValue);

            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void ModifySumAllTestMethod()
        {
            int[] array = { 3, 6, 5, 8, 7, 1, 6 };
            STDelegate st = new STDelegate(array, (x, y) => Math.Min(x, y));
            st.Modify(2, 10);
            var res = st.Query(0, array.Length - 1, int.MaxValue);

            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void ModifyParialsumTestMethod()
        {
            int[] array = { 3, 6, 5, 8, 7, 1, 6 };
            STDelegate st = new STDelegate(array, (x, y) => Math.Min(x, y));
            st.Modify(5, -9);
            var res = st.Query(1, 5, int.MaxValue);

            Assert.AreEqual(-9, res);
        }
    }
}
