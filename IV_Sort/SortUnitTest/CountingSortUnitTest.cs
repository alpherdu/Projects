using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IV_Sort;

namespace SortUnitTest
{
    [TestClass]
    public class CountingSortUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            PerformSort.PerfromSort(CountingSortClass.CountingSort, 1000, false);
        }
    }
}
