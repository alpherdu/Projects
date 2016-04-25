using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IV_Sort;

namespace SortUnitTest
{
    [TestClass]
    public class HeapSortUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            PerformSort.PerfromSort(HeapSortClass.HeapSort,1000, true);
        }
    }
}
