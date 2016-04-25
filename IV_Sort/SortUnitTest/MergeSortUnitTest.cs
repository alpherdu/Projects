using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IV_Sort;

namespace SortUnitTest
{
    [TestClass]
    public class MergeSortUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            PerformSort.PerfromSort(MergeSortClass.MergeSort, 1000, true);
        }
    }
}
