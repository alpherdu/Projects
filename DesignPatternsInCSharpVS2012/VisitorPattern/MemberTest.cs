using VisitorPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace VisitorPattern.Test
{
    [TestClass()]
    public class MemberTest
    {
        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        [TestMethod()]
        public void IsAboveEighteenTest()
        {
            IList<Member> list = new List<Member>()
                {
                    new Member() { Name = "N1", DateOfBirth= new DateTime(2000, 1, 1)},
                    new Member() { Name = "N2", DateOfBirth= new DateTime(2000, 1, 1)},
                    new Member() { Name = "N3", DateOfBirth= new DateTime(1990, 1, 1)},
                    new Member() { Name = "N4", DateOfBirth= new DateTime(1980, 1, 1)}
                };

            var selectedList = list.Where(m => m.IsAboveEighteen);
            foreach (Member member in selectedList)
                Console.WriteLine(member.Name);

            Assert.AreEqual(2, selectedList.Count());
        }
    }
}
