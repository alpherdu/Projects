using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IV_SegmentTree;
using System.Linq;

namespace STDelegateUnitTest
{
    [TestClass]
    public class STDelegateSumUnitTest
    {

        [TestMethod]
        public void SumAllTestMethod()
        {
            int[] array = { 3, 6, 5, 8, 7, 1, 6 };
            STDelegate st = new STDelegate(array, (x, y) => x + y);
            var res = st.Query(0, array.Length - 1, 0);

            Assert.AreEqual(array.Sum(), res);
        }

        [TestMethod]
        public void ParialsumTestMethod()
        {
            int[] array = { 3, 6, 5, 8, 7, 1, 6 };
            STDelegate st = new STDelegate(array, (x, y) => x + y);
            var res = st.Query(1, 5, 0);

            Assert.AreEqual(27, res);
        }

        [TestMethod]
        public void ModifySumAllTestMethod()
        {
            int[] array = { 3, 6, 5, 8, 7, 1, 6 };
            STDelegate st = new STDelegate(array, (x, y) => x + y);
            st.Modify(2, 10);
            var res = st.Query(0, array.Length - 1, 0);

            Assert.AreEqual(array.Sum() + 5, res);
        }

        [TestMethod]
        public void ModifyParialsumTestMethod()
        {
            int[] array = { 3, 6, 5, 8, 7, 1, 6 };
            STDelegate st = new STDelegate(array, (x, y) => x + y);
            st.Modify(5, -9);
            var res = st.Query(1, 5, 0);

            Assert.AreEqual(17, res);
        }
    }
}
