using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IV_Sort;

namespace SortUnitTest
{
    [TestClass]
    public class QuickSortUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            PerformSort.PerfromSort(QuickerSortClass.QuickSort, 1000, true);
        }
    }
}
