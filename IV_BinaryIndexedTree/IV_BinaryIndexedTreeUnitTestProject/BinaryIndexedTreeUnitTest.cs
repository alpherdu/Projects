using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IV_BinaryIndexedTree;


namespace IV_BinaryIndexedTreeUnitTestProject
{
    [TestClass]
    public class BinaryIndexedTreeUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] A = { 2, 1, 1, 3, 2, 3, 4, 5, 6, 7, 8, 9};

            BinaryIndexedTree biTree = new BinaryIndexedTree(A);
            var sum = biTree.GetSum(5);
            Assert.AreEqual(12, sum);

            biTree.Add(3, 6);
            sum = biTree.GetSum(5);
            Assert.AreEqual(18, sum);


        }
    }
}
