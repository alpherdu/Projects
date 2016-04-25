using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IV_Sort;

namespace SortUnitTest
{
    [TestClass]
    public class InsertionSortUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            for (int i = 0; i < 10; i++)
            {
                PerformSort.PerfromSort(InsertionSortClass.Insertionsort, 1000, true);
            }

        }

    }
}
