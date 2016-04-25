using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class RemoveDuplicateLettersOneUnitTest
    {
        [TestMethod]
        public void Lexicographical_TestMethod1()
        {
            string inputString = "abc";


            string expectedOutputString = "abc";

            string resultString = IV.IVClass.RemoveDuplicateLettersOne(inputString);

            Assert.AreEqual<String>(expectedOutputString, resultString);
        }

        [TestMethod]
        public void Lexicographical_TestMethod2()
        {
            string inputString = "cbacdcbc";


            string expectedOutputString = "acdb";

            //string resultString = RemoveDuplicateLettersOne(inputString);
            string resultString = IV.IVClass.RemoveDuplicateLettersTwo(inputString);

            Assert.AreEqual<String>(expectedOutputString, resultString);
        }

        [TestMethod]
        public void Lexicographical_TestMethod3()
        {
            string inputString = "edebbed";


            string expectedOutputString = "bed";

            string resultString = IV.IVClass.RemoveDuplicateLettersOne(inputString);

            Assert.AreEqual<String>(expectedOutputString, resultString);
        }

        [TestMethod]
        public void Lexicographical_TestMethod4()
        {
            string inputString = "cbacdcbc";


            string expectedOutputString = "acdb";

            string resultString = IV.IVClass.RemoveDuplicateLettersOne(inputString);

            Assert.AreEqual<String>(expectedOutputString, resultString);
        }

        [TestMethod]
        public void Lexicographical_TestMethod5()
        {
            string inputString = "bcabc";


            string  outputString = "bcabc";

            string resultString = IV.IVClass.RemoveDuplicateLettersOne(inputString);

            Assert.AreEqual(inputString, resultString);
        }
    }
}
