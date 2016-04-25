using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IV_SegmentTree;
using System.Linq;

namespace SegmentTreeUnitTest
{
    [TestClass]
    public class STSumUnitTest
    {
        [TestMethod]
        public void EmptyTestMethod()
        {
            int[] array = { };
            SegmentTree st = new SegmentTree(array);
            var x = st.Query(0, array.Length - 1);

            Assert.AreEqual(array.Sum(), x);
        }

        [TestMethod]
        public void OneElementTestMethod()
        {
            int[] array = { 3 };
            SegmentTree st = new SegmentTree(array);
            var x = st.Query(0, array.Length - 1);

            Assert.AreEqual(array.Sum(), x);
        }

        [TestMethod]
        public void SumAllTestMethod()
        {
            int[] array = { 3, 6, 5, 8, 7, 1, 6 };
            SegmentTree st = new SegmentTree(array);
            var x = st.Query(0, array.Length - 1);

            Assert.AreEqual(array.Sum(), x);
        }

        [TestMethod]
        public void OneParialSumTestMethod()
        {
            int[] array = { 3, 6, 5, 8, 7, 1, 6 };
            SegmentTree st = new SegmentTree(array);
            var x = st.Query(3, 3);

            Assert.AreEqual(array[3], x);
        }

        [TestMethod]
        public void ParialsumTestMethod()
        {
            int[] array = { 3, 6, 5, 8, 7, 1, 6 };
            SegmentTree st = new SegmentTree(array);
            var x = st.Query(1, 5);

            Assert.AreEqual(27, x);
        }

        [TestMethod]
        public void ModifySumAllTestMethod()
        {
            int[] array = { 3, 6, 5, 8, 7, 1, 6 };
            SegmentTree st = new SegmentTree(array);
            st.Modify(2, 10);
            var x = st.Query(0, array.Length - 1);

            Assert.AreEqual(array.Sum() + 5, x);
        }

        [TestMethod]
        public void ModifyParialsumTestMethod()
        {
            int[] array = { 3, 6, 5, 8, 7, 1, 6 };
            SegmentTree st = new SegmentTree(array);
            st.Modify(5, -9);
            var x = st.Query(1, 5);

            Assert.AreEqual(17, x);
        }
    }
}
