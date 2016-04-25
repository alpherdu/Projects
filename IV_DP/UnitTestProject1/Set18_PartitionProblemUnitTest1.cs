using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class Set18_PartitionProblemUnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] arr = { 3, 1, 5, 9, 12 };
            StringBuilder sb = new StringBuilder();

            IV.Set18_PartitionProblem pp = new IV.Set18_PartitionProblem();
            pp.Partition(arr,sb);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //int[] arr = { 2, 1, 4, 3, 6 };
            int[] arr = { 3, 1, 2, 6, 4 };
            StringBuilder sb = new StringBuilder();

            IV.Set18_PartitionProblem pp = new IV.Set18_PartitionProblem();
            var x = pp.HalfSumSubset(arr);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] arr = { 3, 1, 5, 9, 12 };
            StringBuilder sb = new StringBuilder();

            IV.Set18_PartitionProblem pp = new IV.Set18_PartitionProblem();
            var x = pp.Partition_dp(arr);
        }

        [TestMethod]
        public void TestMethod4()
        {
            //int[] arr = { 2, 1, 4, 3, 6 };
            int[] arr = { 3, 1, 2, 6, 4 };
            StringBuilder sb = new StringBuilder();

            IV.Set18_PartitionProblem pp = new IV.Set18_PartitionProblem();
            var x = pp.Partition_dp(arr);
        }
    }
}
