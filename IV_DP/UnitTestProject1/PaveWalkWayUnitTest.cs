using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class PaveWalkWayUnitTest
    {
        [TestMethod]
        public void NegativeLen_TestMethod3()
        {
            int walkWayLen = -10;
            int[] brickSet = { 1, 2, 5 };

            long expectedResult = 0;
            long result = IV.PaveWalkWay.PaveWalkWay_DP(walkWayLen, brickSet);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void ZeroLen_TestMethod3()
        {
            int walkWayLen = 0;
            int[] brickSet = { 1, 2, 5 };

            long expectedResult = 0;
            long result = IV.PaveWalkWay.PaveWalkWay_DP(walkWayLen, brickSet);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void NullBrickSet_TestMethod3()
        {
            int walkWayLen = 10;
            int[] brickSet = null;

            long expectedResult = 0;
            long result = IV.PaveWalkWay.PaveWalkWay_DP(walkWayLen, brickSet);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void UnitBrick_TestMethod3()
        {
            int walkWayLen = 10;
            int[] brickSet = { 1 };

            long expectedResult = 1;
            long result = IV.PaveWalkWay.PaveWalkWay_DP(walkWayLen, brickSet);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeBrickLen_TestMethod()
        {
            int walkWayLen = 10;
            int[] brickSet = { 1,-2, 3 };

            long expectedResult = 1;
            long result = IV.PaveWalkWay.PaveWalkWay_DP(walkWayLen, brickSet);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DupBrickLensTestMethod()
        {
            int walkWayLen = 4;
            int[] brickSet = { 1, 2, 2, 3 };

            long expectedResult = 7;
            long result = IV.PaveWalkWay.PaveWalkWay_DP(walkWayLen, brickSet);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void BrickTooLongTestMethod()
        {
            int walkWayLen = 2;
            int[] brickSet = { 3, 5, 7};

            long expectedResult = 0;
            long result = IV.PaveWalkWay.PaveWalkWay_DP(walkWayLen, brickSet);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestMethod1()
        {
            int walkWayLen = 4;
            int[] brickSet = { 1, 2, 3};

            long expectedResult = 7;
            long result = IV.PaveWalkWay.PaveWalkWay_DP(walkWayLen, brickSet);

            Assert.AreEqual(expectedResult, result);
        }


        [TestMethod]
        public void TestMethod2()
        {
            int walkWayLen = 10;
            int[] brickSet = { 1, 2, 3 };

            long expectedResult = 274;
            long result = IV.PaveWalkWay.PaveWalkWay_DP(walkWayLen, brickSet);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int walkWayLen = 10;
            int[] brickSet = { 1, 2, 5 };

            long expectedResult = 128;
            long result = IV.PaveWalkWay.PaveWalkWay_DP(walkWayLen, brickSet);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
