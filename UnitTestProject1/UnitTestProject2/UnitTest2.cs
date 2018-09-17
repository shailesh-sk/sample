using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest2
    {
        //private TestContext testContextInstance;
        //string fileName = Path.GetTempFileName();

        //public TestContext TestContext
        //{
        //    get
        //    {
        //        return testContextInstance;
        //    }
        //    set
        //    {
        //        testContextInstance = value;
        //    }
        //}

        [TestMethod]
        [OwnerAttribute("owner5")]
        public void TestMethod1()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        [OwnerAttribute("owner6")]
        public void TestMethod2()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        [OwnerAttribute("owner3")]
        public void TestMethod3()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        [OwnerAttribute("owner5")]
        public void TestMethod4()
        {
            //File.WriteAllText(fileName, "SomeJunk");
            //this.TestContext.AddResultFile(fileName);
            Assert.IsTrue(false);
        }

        [TestMethod]
        [OwnerAttribute("owner5")]
        public void TestMethod5()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        [OwnerAttribute("owner6")]
        public void TestMethod6()
        {
            //File.WriteAllText(fileName, "SomeJunk");
            //this.TestContext.AddResultFile(fileName);
            Assert.IsTrue(false);
        }

        [OwnerAttribute("owner6")]
        [TestMethod]
        public void TestMethod7()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        [OwnerAttribute("owner3")]
        public void TestMethod8()
        {
            Assert.IsTrue(true);
        }


        [TestMethod]
        [OwnerAttribute("owner3")]
        public void TestMethod9()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        [OwnerAttribute("owner4")]
        public void TestMethod10()
        {
            Assert.IsTrue(true);
        }
    }
}
