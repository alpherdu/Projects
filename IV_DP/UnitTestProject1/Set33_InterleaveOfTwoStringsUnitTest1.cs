using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class Set33_InterleaveOfTwoStringsUnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IV.Set33_InterleaveOfTwoStrings ioftw = new IV.Set33_InterleaveOfTwoStrings();
            var x = ioftw.IsInterLeaved("XXY", "XXZ", "XXZXXXY");

            Assert.AreEqual(false, x);
        }

        [TestMethod]
        public void TestMethod2()
        {
            IV.Set33_InterleaveOfTwoStrings ioftw = new IV.Set33_InterleaveOfTwoStrings();
            var x = ioftw.IsInterLeaved("XY", "WZ", "WZXY");

            Assert.AreEqual(true, x);
        }

        [TestMethod]
        public void TestMethod3()
        {
            IV.Set33_InterleaveOfTwoStrings ioftw = new IV.Set33_InterleaveOfTwoStrings();
            var x = ioftw.IsInterLeaved("XY", "X", "XXY");

            Assert.AreEqual(true, x);
        }

        [TestMethod]
        public void TestMethod4()
        {
            IV.Set33_InterleaveOfTwoStrings ioftw = new IV.Set33_InterleaveOfTwoStrings();
            var x = ioftw.IsInterLeaved("YX", "X", "XXY");

            Assert.AreEqual(false, x);
        }

        [TestMethod]
        public void TestMethod5()
        {
            IV.Set33_InterleaveOfTwoStrings ioftw = new IV.Set33_InterleaveOfTwoStrings();
            var x = ioftw.IsInterLeaved("XXY", "XXZ", "XXXXZY"); ;

            Assert.AreEqual(true, x);
        }
    }
}
