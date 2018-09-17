using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private TestContext testContextInstance;
        string fileName = Path.GetTempFileName();

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

        [TestMethod]
        [OwnerAttribute("owner1")]
        public void TestMethod1()
        {
            File.WriteAllText(fileName, "SomeJunk");
            this.TestContext.AddResultFile(fileName);
            Assert.IsTrue(false);
        }

        [TestMethod]
        [OwnerAttribute("owner2")]
        public void TestMethod2()
        {
            File.WriteAllText(fileName, "SomeJunk");
            this.TestContext.AddResultFile(fileName);
            Assert.IsTrue(false);
        }

        [TestMethod]
        [OwnerAttribute("owner3")]
        public void TestMethod3()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        [OwnerAttribute("owner1")]
        public void TestMethod4()
        {
            File.WriteAllText(fileName, "SomeJunk");
            this.TestContext.AddResultFile(fileName);
            Assert.IsTrue(false);
        }

        [TestMethod]
        [OwnerAttribute("owner1")]
        public void TestMethod5()
        {
            File.WriteAllText(fileName, "SomeJunk");
            this.TestContext.AddResultFile(fileName);
            Assert.IsTrue(true);
        }

        [TestMethod]
        [OwnerAttribute("owner2")]
        public void TestMethod6()
        {
            Assert.IsTrue(true);
        }

        [OwnerAttribute("owner2")]
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
